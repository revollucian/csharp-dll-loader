using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace HWIDGbr
{
    class hwid
    {
        public static string GetMachineGuid()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";

            using (RegistryKey localmachinex64view = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localmachinex64view.OpenSubKey(location))
                {

                    if (rk == null)
                        throw new KeyNotFoundException(string.Format("Key not found : {0}", location));
                    object machineGuid = rk.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(string.Format("Index not found: {0}", name));
                    return machineGuid.ToString();

                }

            }
        }

        public static string getuserid()
        {
            string userid = System.Environment.MachineName;
            if (userid == null)
                userid = "o";
            object getuserid = userid;
            return getuserid.ToString();
 
        }
    }
}


