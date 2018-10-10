using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace WLMerge
{
    /// <summary>
    ///     A generic sortable list that can be data bound. It is built upon the BindingList, but with
    ///     sorting functionality added.
    /// </summary>
    /// <typeparam name="TT">
    ///     Type of the list.
    /// </typeparam>
    public class SortableBindingList<TT> : BindingList<TT>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SortableBindingList{TT}" /> class.
        /// </summary>
        /// <param name="list">
        ///     The list.
        /// </param>
        public SortableBindingList(IList<TT> list)
            : base(list)
        {
        }

        #endregion

        /// <summary>
        ///     The property comparer.
        /// </summary>
        internal class PropertyComparer : Comparer<TT>
        {
            #region Constructors and Destructors

            /// <summary>
            ///     Initializes a new instance of the <see cref="PropertyComparer" /> class.
            /// </summary>
            /// <param name="prop">
            ///     The property descriptor.
            /// </param>
            /// <param name="direction">
            ///     The direction to sort.
            /// </param>
            /// <exception cref="MissingMemberException">
            ///     Raised if property descriptor is of wrong type.
            /// </exception>
            internal PropertyComparer(PropertyDescriptor prop, ListSortDirection direction)
            {
                if (prop.ComponentType != typeof(TT))
                {
                    throw new MissingMemberException(typeof(TT).Name, prop.Name);
                }

                this.prop = prop;
                this.direction = direction;

                if (OkWithIComparable(prop.PropertyType))
                {
                    var comparerType = typeof(Comparer<>).MakeGenericType(prop.PropertyType);
                    var defaultComparer = comparerType.GetProperty("Default");
                    this.comparer = (IComparer)defaultComparer.GetValue(null, null);
                    this.useToString = false;
                }
                else if (OkWithToString(prop.PropertyType))
                {
                    this.comparer = StringComparer.CurrentCultureIgnoreCase;
                    this.useToString = true;
                }
            }

            #endregion

            #region Fields

            /// <summary>
            ///     The comparer.
            /// </summary>
            private readonly IComparer comparer;

            /// <summary>
            ///     The direction.
            /// </summary>
            private readonly ListSortDirection direction;

            /// <summary>
            ///     The prop.
            /// </summary>
            private readonly PropertyDescriptor prop;

            /// <summary>
            ///     The use to string.
            /// </summary>
            private readonly bool useToString;

            #endregion

            #region Public Methods and Operators

            /// <summary>
            ///     The is allowable.
            /// </summary>
            /// <param name="t">
            ///     The t.
            /// </param>
            /// <returns>
            ///     The <see cref="bool" />.
            /// </returns>
            public static bool IsAllowable(Type t)
            {
                return OkWithToString(t) || OkWithIComparable(t);
            }

            /// <summary>
            ///     The compare.
            /// </summary>
            /// <param name="x">
            ///     The x.
            /// </param>
            /// <param name="y">
            ///     The y.
            /// </param>
            /// <returns>
            ///     The <see cref="int" />.
            /// </returns>
            public override int Compare(TT x, TT y)
            {
                // ReSharper disable AssignNullToNotNullAttribute
                var valueX = this.prop.GetValue(x);
                var valueY = this.prop.GetValue(y);

                // ReSharper restore AssignNullToNotNullAttribute
                if (this.useToString)
                {
                    valueX = valueX?.ToString();
                    valueY = valueY?.ToString();
                }

                return this.direction == ListSortDirection.Ascending
                    ? this.comparer.Compare(valueX, valueY)
                    : this.comparer.Compare(valueY, valueX);
            }

            #endregion

            #region Methods

            /// <summary>
            ///     The ok with i comparable.
            /// </summary>
            /// <param name="t">
            ///     The t.
            /// </param>
            /// <returns>
            ///     The <see cref="bool" />.
            /// </returns>
            protected static bool OkWithIComparable(Type t)
            {
                return (t.GetInterface("IComparable") != null)
                       || (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
            }

            /// <summary>
            ///     The ok with to string.
            /// </summary>
            /// <param name="t">
            ///     The t.
            /// </param>
            /// <returns>
            ///     The <see cref="bool" />.
            /// </returns>
            protected static bool OkWithToString(Type t)
            {
                // this is the list of types that behave specially for the purpose of
                // sorting. if we have a property of this type, and it does not implement
                // IComparable, then this class will sort the properties according to the
                // ToString() method.

                // In the case of an XNode, the ToString() returns the
                // XML, which is what we care about.
                return t == typeof(XNode) || t.IsSubclassOf(typeof(XNode));
            }

            #endregion
        }

        #region Fields

        /// <summary>
        ///     The is sorted.
        /// </summary>
        private bool isSorted;

        /// <summary>
        ///     The sort direction.
        /// </summary>
        private ListSortDirection sortDirection = ListSortDirection.Ascending;

        /// <summary>
        ///     The sort property.
        /// </summary>
        private PropertyDescriptor sortProperty;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets a value indicating whether is sorted core.
        /// </summary>
        protected override bool IsSortedCore => this.isSorted;

        /// <summary>
        ///     Gets the sort direction core.
        /// </summary>
        protected override ListSortDirection SortDirectionCore => this.sortDirection;

        /// <summary>
        ///     Gets the sort property core.
        /// </summary>
        protected override PropertyDescriptor SortPropertyCore => this.sortProperty;

        /// <summary>
        ///     Gets a value indicating whether supports sorting core.
        /// </summary>
        protected override bool SupportsSortingCore => true;

        #endregion

        #region Methods

        /// <summary>
        ///     The apply sort core.
        /// </summary>
        /// <param name="prop">
        ///     The prop.
        /// </param>
        /// <param name="direction">
        ///     The direction.
        /// </param>
        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            // Only apply sort if the column is sortable, decision was made not to throw in this case.
            // Don't prevent nullable types from working.
            var propertyType = prop.PropertyType;

            if (PropertyComparer.IsAllowable(propertyType))
            {
                ((List<TT>)this.Items).Sort(new PropertyComparer(prop, direction));
                this.sortDirection = direction;
                this.sortProperty = prop;
                this.isSorted = true;
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
        }

        /// <summary>
        ///     The remove sort core.
        /// </summary>
        protected override void RemoveSortCore()
        {
            this.isSorted = false;
            this.sortProperty = null;
        }

        #endregion
    }
}

