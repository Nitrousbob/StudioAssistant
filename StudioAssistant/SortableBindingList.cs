using System.ComponentModel;

// This class provides a sortable binding list that can be used to bind to a DataGridView
// or other controls that support sorting. It extends the BindingList<T> class and implements
// the necessary methods to enable sorting based on a specified property and direction.
//Gemini helped create this snippet after I asked for sorting functionality for the DataGridView in Form1.
//I wanted to be able to click on the column headers to sort the artists by that column, and this class
//provides that functionality. I reused this classs because I like the functionality it provides.

namespace StudioAssistant
{
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;
        private PropertyDescriptor _sortProperty;

        public SortableBindingList() { }
        public SortableBindingList(IList<T> list) : base(list) { }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _isSorted;
        protected override ListSortDirection SortDirectionCore => _sortDirection;
        protected override PropertyDescriptor SortPropertyCore => _sortProperty;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;

            var items = this.Items as List<T>;
            if (items != null)
            {
                var pc = new PropertyComparer<T>(prop, direction);
                items.Sort(pc);
                _isSorted = true;
            }
            else
            {
                _isSorted = false;
            }

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortProperty = null;
        }
    }

    public class PropertyComparer<T> : IComparer<T>
    {
        private readonly PropertyDescriptor _prop;
        private readonly ListSortDirection _direction;

        public PropertyComparer(PropertyDescriptor prop, ListSortDirection direction)
        {
            _prop = prop;
            _direction = direction;
        }

        public int Compare(T x, T y)
        {
            var xVal = _prop.GetValue(x);
            var yVal = _prop.GetValue(y);

            int result = Comparer<object>.Default.Compare(xVal, yVal);

            return _direction == ListSortDirection.Ascending ? result : -result;
        }
    }
}
