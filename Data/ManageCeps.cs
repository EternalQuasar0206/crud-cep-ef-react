using crud_cep.Models;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace crud_cep.Data {
    public static class ManageCeps {
        public static async Task<ActionResponse> AddCep(Cep cep) {
            try {
                db_selecao_imdbContext Context = new();
                await Context.Ceps.AddAsync(cep);
                await Context.SaveChangesAsync();
                return new ActionResponse() { 
                    result = "Success"
                };
            }
            catch(Exception e) {
                return new ActionResponse() { 
                    result = e.ToString()
                };
            }
        }

        public static async Task<Cep> RetrieveCep(string cep) {
            return await Task.Run(() => {
                Cep result = new();
                try {
                    db_selecao_imdbContext Context = new();
                    result = Context.Ceps.Where(x => x.CepString == cep).FirstOrDefault();                
                }
                catch(Exception e) {
                    throw new Exception(e + "");
                }
                return result;
            });

        }
    }
}