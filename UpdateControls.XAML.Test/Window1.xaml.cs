﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UpdateControls.XAML.Test
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
        private PersonListPresentation _personListPresentation =
            new PersonListPresentation(new PersonList(), new PersonListNavigation());

		public Window1()
		{
			InitializeComponent();
            DataContext = _personListPresentation;
		}

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Person newPerson = _personListPresentation.PersonList.NewPerson();
            _personListPresentation.Navigation.SelectedPerson = newPerson;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (_personListPresentation.Navigation.SelectedPerson != null)
                _personListPresentation.PersonList.DeletePerson(_personListPresentation.Navigation.SelectedPerson);
        }
    }
}
