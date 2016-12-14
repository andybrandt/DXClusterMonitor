using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace DXClusterMonitor
{

    public class ClusterNetServices
    {
        public Queue<Spot> netLoadSpotsFromApi()
        {
            Queue<Spot> currentSpots = new Queue<Spot>();
            using (WebClient mywebClient = new WebClient())
            {
                // ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

                var spotsInString = mywebClient.DownloadString("http://www.dxcluster.co.uk/index.php?/api/all");
            }

            return currentSpots;
        }
    }

}