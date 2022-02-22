
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Recycler;
using System;
using System.Collections.Generic;

namespace Recycler
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme" , MainLauncher =true)]
    public class MainActivity : AppCompatActivity
    {
        private RecyclerView _emploeeRecyclerView;
        private List<string> _employeeNames;
        private EmployeeAdapter _employeeAdapter;
        private ListView _employeeList;
        RecyclerView.LayoutManager _layoutManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            _emploeeRecyclerView = FindViewById<RecyclerView>(Resource.Id._employeeRecyclerView);
            _employeeList = FindViewById<ListView>(Resource.Id._employeeList);

            GenerateDummyRecords();
            _layoutManager = new GridLayoutManager(this,2,GridLayoutManager.Vertical,false);
            _employeeAdapter = new EmployeeAdapter(_employeeNames);
            _emploeeRecyclerView.SetLayoutManager(_layoutManager);
            _emploeeRecyclerView.SetAdapter(_employeeAdapter);

           
            
        }

        private void _employeeAdapter_ItemClick(object sender, int e)
        {
            //Toast.MakeText(this, "hii" + _employeeNames[].ToString(), ToastLength.Long).Show();
            Toast.MakeText(this,"Hoo"+ _employeeNames[e].ToString(), ToastLength.Short).Show();
        }

        private void GenerateDummyRecords()
        {
            _employeeNames = new List<string>();

            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
            _employeeNames.Add(item: "Bottol");
            _employeeNames.Add(item: "pencil");
            _employeeNames.Add(item: "eraser");
            _employeeNames.Add(item: "Car");
            _employeeNames.Add(item: "Bag");
        }
}
}
