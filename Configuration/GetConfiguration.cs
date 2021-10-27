using crud_cep.Models;
using System.IO;
using System.Text.Json;
using System;

namespace crud_cep.Configuration {
    public static class GetConfiguration {
        public static Config FromConfig() {
            Config cfg;
            var cfgRaw = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/config.json");
            cfg = JsonSerializer.Deserialize<Config>(cfgRaw);
            return cfg;
        }
    }
}