using Parviz.AdvertisementApp.Dtos.Inferfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.Dtos
{
    public class AdvertisementCreateDto:IDto
    {
        public string Title { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
