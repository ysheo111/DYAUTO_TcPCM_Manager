﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TcPCM_Connect_Global;
using System.Globalization;
using System.Data;

namespace TcPCM_Connect.xaml
{
    /// <summary>
    /// TreeGrid.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TreeGrid : UserControl
    {
		private const int Levels = 3;
		private const int Roots = 100;
		private const int ItemsPerLevel = 5;

		private int value;
		private TreeGridModel model;
		public TreeGrid()
        {
            InitializeComponent();

			// Initialize the model
			InitModel();

			// Set the model for the grid
			grid.ItemsSource = model.FlatModel;
		}

		public void SetItemSource(DataTable dataTable)
        {		
			for(int i=1; i< grid.Columns.Count; i++)
            {
				grid.Columns.RemoveAt(i);
			}
			// DataTable의 Default View를 바인딩하기
			foreach (DataColumn col in dataTable.Columns)
            {
				if (col.ColumnName == "Node") continue;
				DataGridTextColumn textColumn = new DataGridTextColumn();
				textColumn.Header = col.ColumnName;
				textColumn.Binding = new Binding(col.ColumnName);
				grid.Columns.Add(textColumn);
			}

			grid.ItemsSource = dataTable.DefaultView;
		}

		private void InitModel()
		{
			// Create the model
			model = new TreeGridModel();

			// Add a bunch of items at the root
			for (int count = 0; count < Roots; count++)
			{
				// Create the root item
				Item root = new Item(String.Format("Root {0}", count), value++, true);

				// Add children to the root
				AddChildren(root);

				// Add the root to the model
				model.Add(root);
			}
		}

		private int c(Item i)
		{
			int cnt = i.Children.Count;

			foreach (Item child in i.Children)
			{
				cnt += c(child);
			}

			return cnt;
		}

		private void AddChildren(Item item, int level = 0)
		{
			// Determine if the item will have children
			bool hasChildren = (level < Levels);

			// Create children for the item
			for (int count = 0; count < ItemsPerLevel; count++)
			{
				// Create the child
				Item child = new Item(String.Format("Child {0}, Level {1}", count, level), value++, hasChildren);

				// Does the child have children?
				if (hasChildren)
				{
					// Recursively add children to the child
					AddChildren(child, (level + 1));
				}

				// Add the child to the item
				item.Children.Add(child);
			}
		}		
	}

	public class VisibilityConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// If the item has children, then show the checkbox, otherwise hide it
			return ((bool)value ? Visibility.Visible : Visibility.Hidden);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

	public class LevelConverter : IValueConverter
	{
		public GridLength LevelWidth { get; set; }

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			// Return the width multiplied by the level
			return ((int)value * LevelWidth.Value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}

	public class Item : TreeGridElement
	{
		public int Value { get; private set; }
		public string Name { get; private set; }

		public Item(string name, int value, bool hasChildren)
		{
			// Initialize the item
			Name = name;
			Value = value;
			HasChildren = hasChildren;
		}
	}
}
