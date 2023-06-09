﻿using PlayerProfile.Abstract;
using PlayerProfile.Entities;
using PlayerProfile.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerProfile.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
           KPSPublicSoapClient client= new KPSPublicSoapClient();

            return client.TCKimlikNoDogrula(Convert.ToInt64(player.NationalityId),player.FirstName.ToUpper(),player.Lastname.ToUpper(),player.DateOfBirth.Year);
            
        }
    }
}
