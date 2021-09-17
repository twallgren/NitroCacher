﻿using NitroCacher.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NitroCacher.Plugins
{
    public class XmlFileConfigManager : IConfigManager
    {
        string _configPath;
        public XmlFileConfigManager()
        {
            var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            _configPath = Path.Combine(appDataFolder, "NitroCacher", "Settings.config");
        }

        public T GetConfig<T>() where T : class
        {
            try
            {
                Directory.CreateDirectory(new FileInfo(_configPath).DirectoryName);
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(_configPath));
            }
            catch
            {
                return null;
            }
        }

        public void SaveConfig<T>(T config) where T : class
        {
            Directory.CreateDirectory(new FileInfo(_configPath).DirectoryName);
            File.WriteAllText(_configPath, JsonConvert.SerializeObject(config));
        }
    }
}
