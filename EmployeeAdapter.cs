using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recycler
{ 
    class EmployeeAdapter : RecyclerView.Adapter
    {
        private List<string> _employeesName;
        private event EventHandler<int> ItemClick;
        public EmployeeAdapter(List<string> employeesName)
        {
            _employeesName = employeesName;
        }
        public override int ItemCount => _employeesName.Count;
        
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            EmployeeViewHolder viewHolder = holder as EmployeeViewHolder;
            viewHolder.BindData(_employeesName[position]);
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).
            Inflate(Resource.Layout.employee_list_row_item, parent, attachToRoot: false);
            return new EmployeeViewHolder(view,OnClick);
        }

        private void OnClick(int position)
        {
            if (ItemClick != null)
            {
                ItemClick?.Invoke(this, position);
            }
            ItemClick?.Invoke(this, position);
        }
        class EmployeeViewHolder : RecyclerView.ViewHolder
        {
            private TextView _employeeNameTextView;
            
            public EmployeeViewHolder(View itemView, Action<int> listener) : base(itemView)
            {
                var textView = itemView.FindViewById<TextView>(Resource.Id._employeeNameTextView);
                _employeeNameTextView = textView;
            _employeeNameTextView.Click += (s, e) => listener.Invoke(LayoutPosition);
            }
            internal void BindData(string employeeName)
            {
                _employeeNameTextView.Text = employeeName;
            }
        }
    }
}
    