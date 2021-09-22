using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp12.Command;
using WpfApp12.Models;
using WpfApp12.Repository;

namespace WpfApp12.ViewModels
{
    public class EditViewModel
    {
        public Car MyCar { get; set; }
        public RelayCommand CloseCommand { get; set; }

        public EditViewModel()
        {
            CloseCommand = new RelayCommand(a=>
            {
                if (a is Window window)
                {
                    window.Close();
                }
            },p => true );


        }
    }
}
