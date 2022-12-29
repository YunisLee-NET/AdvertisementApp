using Parviz.AdvertisementApp.Dtos.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Dtos
{
    public class GenderListDto:IDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
