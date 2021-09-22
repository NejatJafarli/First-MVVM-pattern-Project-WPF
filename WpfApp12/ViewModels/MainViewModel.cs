using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp12.Command;
using WpfApp12.Models;
using WpfApp12.Repository;
using WpfApp12.ViewModels;
using WpfApp12.Views;

namespace WpfApp12.VIewModels
{
    public class MainViewModel
    {
        public Car MyCar { get; set; }
        public RelayCommand ShowCommand { get; set; }
        public RelayCommand EditCommand { get; set; }
        public RelayCommand IndexChangedCommand { get; set; }
        public EditViewModel EditViewModel { get; set; }

        public ObservableCollection<Car> Cars { get; set; }




        public MainViewModel()
        {

            Cars = new FakeRepo().Cars;

            ShowCommand = new RelayCommand(
                e =>
                {
                    MessageBox.Show($"{MyCar.Vendor}--{MyCar.Model}--{MyCar.Year}");
                },
                p => true);

            EditCommand = new RelayCommand(
              e =>
              {
                  EditViewModel = new EditViewModel();
                  EditViewModel.MyCar = MyCar;

                  var NewWindows = new EditView();
                  NewWindows.DataContext = EditViewModel;
                  NewWindows.ShowDialog();
              },
              p => true);
        }
    }
}
