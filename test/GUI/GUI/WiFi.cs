using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NativeWifi;

namespace GUI
{
    public class WiFi
    {
       
        public List<KeyValuePair<string, uint>> networksList()
        {
            WlanClient client = new WlanClient(); 
            
            List<KeyValuePair<string, uint>> myNetworks = new List<KeyValuePair<string, uint>>();
            string tmpNWname;
            uint signalStrength = 999;
            
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                
                Wlan.WlanBssEntry[] wlanBssEntries = wlanIface.GetNetworkBssList();
                foreach (Wlan.WlanBssEntry network in wlanBssEntries)
                {
                    /*
                    byte[] macAddr = network.dot11Bssid;
                    string tMac = "";
                    for (int i = 0; i < macAddr.Length; i++)
                    {
                       tMac += macAddr[i].ToString("x2").PadLeft(2, '0').ToUpper();
                    }
                    */

                    // Console.WriteLine("Found network with SSID: {0}.", GetStringForSSID(network.dot11Ssid));
                    // Console.WriteLine("Signal: {0}%.", network.linkQuality);
                    tmpNWname = GetStringForSSID(network.dot11Ssid);                    
                    signalStrength = network.linkQuality;

                    myNetworks.Add(new KeyValuePair<string, uint>(tmpNWname, signalStrength));                   
                    
                    //Console.WriteLine("BSS Type: {0}.", network.dot11BssType);
                    //Console.WriteLine("BSS id: {0}.", network.dot11Bssid.ToString());
                    //Console.WriteLine("MAC: {0}.", tMac);

                }
            }
            return myNetworks;
        }

        static string GetStringForSSID(Wlan.Dot11Ssid ssid)
        {
            return Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
        }
    }
}
