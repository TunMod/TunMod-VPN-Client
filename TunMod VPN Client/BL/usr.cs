using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TunMod_VPN_Client.Model;

namespace TunMod_VPN_Client.BL
{
    public class usr
    {

        public static string _FilePath = Application.StartupPath + "\\usr\\usr.dat";

        public static List<SSHConfig> ReadAllConfig()
        {
      
       

            try
            {

                using (var stream = File.Open(_FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    var reader = new StreamReader(stream);


                    List<SSHConfig> _Configs = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SSHConfig>>(reader.ReadToEnd());
                    reader.Close();
                    stream.Close();

                    return _Configs;
                }

            }
            catch
            {
                return null;
            }
        }


        public static List<SSHConfig> WriteConfig(SSHConfig _SSHConfig , int _EditMode)
        {
 

            List<SSHConfig>  _SSHList = ReadAllConfig();

            List<SSHConfig> _TempList = new List<SSHConfig>();

            if(_SSHList != null)
                 _TempList.AddRange(_SSHList);

            if (_EditMode == 0)
            {
                for (int i = 0; i < _TempList.Count; i++)
                {
                    _TempList[i].C_Default = false;
                }

                 _TempList.Add(_SSHConfig);
            }
            else if (_EditMode == 1)
            {
                for (int i = 0; i < _TempList.Count; i++)
                {
                    _TempList[i].C_Default = false;

                    if (_TempList[i].id == _SSHConfig.id)
                    {
                        _TempList[i].C_Name = _SSHConfig.C_Name;

                        _TempList[i].C_Host = _SSHConfig.C_Host;
                        _TempList[i].C_Port = _SSHConfig.C_Port;


                        _TempList[i].C_User = _SSHConfig.C_User;
                        _TempList[i].C_Pass = _SSHConfig.C_Pass;

                        _TempList[i].C_Default = true;


                    }
                }
            }
            else if (_EditMode == 2)
            {
                int _TemoID = -1;

                for (int i = 0; i < _TempList.Count; i++)
                {
                    if (_TempList[i].id == _SSHConfig.id)
                    {
                        _TemoID = i;
                    }
                }

                _TempList.RemoveAt(_TemoID);
            }

            var _ConfigJson = Newtonsoft.Json.JsonConvert.SerializeObject(_TempList);



            //FileInfo fi = new FileInfo(_FilePath);
            //bool exists = fi.Exists;

            //if(!exists)
            //{
            //    File.Create(_FilePath);
            //}

            //File.WriteAllText(_FilePath, String.Empty);

            //using (var stream = File.Open(_FilePath, FileMode.Open, FileAccess.Write, FileShare.Read))
            //{
            //    TextWriter tsw = new StreamWriter(stream);
            //    tsw.Write(string.Empty);
            //    tsw.Close();
            //    stream.Close();
            //}

            //Thread.Sleep(200);

            try
            {
                File.Delete(_FilePath);
            }
            catch
            { }

            Thread.Sleep(200);

            using (var stream = File.Open(_FilePath, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                TextWriter tsw = new StreamWriter(stream);
                tsw.Write(_ConfigJson);
                tsw.Close();
                stream.Close();
            }


            return _TempList;

        }


        public static SSHConfig LoadConfig(long _ConfigID)
        {
            List<SSHConfig> _SSHList = ReadAllConfig();

            int _tempId = -1;

            for (int i = 0; i < _SSHList.Count; i++)
            {
                if (_SSHList[i].id == _ConfigID)
                    _tempId = i;
            }

            return _SSHList[_tempId];
        }


        public static SSHConfig GetDefault()
        {
            List<SSHConfig> _SSHList = ReadAllConfig();

            int _tempId = -1;

            if (_SSHList != null)
            {

                for (int i = 0; i < _SSHList.Count; i++)
                {
                    if (_SSHList[i].C_Default == true)
                        _tempId = i;
                }

                if (_tempId == -1)
                    return null;
                return _SSHList[_tempId];
            }
            else
                return null;
        }

    }
}
