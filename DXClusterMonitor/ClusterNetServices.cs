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
                // moze ServicePointManager.CertificatePolicy by pomoglo?
                // moze to by pomoglo ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
                // to ponizej pomoglo :)
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                mywebClient.Headers["User-Agent"] = "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-US; rv:1.9.2.15) Gecko/20110303 Firefox/3.6.15";

                var spotsInString = mywebClient.DownloadString("https://www.dxcluster.co.uk/index.php?/api/all");
            }

            return currentSpots;
        }
    }

}