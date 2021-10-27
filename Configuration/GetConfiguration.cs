using crud_cep.Models;
using System.IO;
using System.Text.Json;

namespace crud_cep.Configuration {
    public static class GetConfiguration {
        public static Config FromConfig() {
            Config cfg;
            var cfgRaw = File.ReadAllText("/config.json");
            cfg = JsonSerializer.Deserialize<Config>(cfgRaw);
            return cfg;
        }
    }
}