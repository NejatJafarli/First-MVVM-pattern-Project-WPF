using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp12.Models;

namespace WpfApp12.Repository
{
    public class FakeRepo
    {
        public ObservableCollection<Car> Cars { get; set; }
        public FakeRepo()
        {
            Cars=new ObservableCollection<Car>();

            Cars.Add(new Car {id=Guid.NewGuid(),Model="X1",Vendor="BMW1",Year=2001 });
            Cars.Add(new Car {id=Guid.NewGuid(),Model="X2",Vendor="BMW2",Year=2002 });
            Cars.Add(new Car {id=Guid.NewGuid(),Model="X3",Vendor="BMW3",Year=2003 });
            Cars.Add(new Car {id=Guid.NewGuid(),Model="X4",Vendor="BMW4",Year=2004 });
        }
    }
}
