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
                    result = "Valor gravado com sucesso"
                };
            }
            catch {
                return new ActionResponse() { 
                    result = "Verifique os se valores inseridos existem ou estão no formato correto"
                };
            }
        }

        public static async Task<ActionResponse> RetrieveCep(string cep) {
            return await Task.Run(() => {
                ActionResponse result = new();
                try {
                    db_selecao_imdbContext Context = new();
                    result.result = "[s]";
                    result.cep = Context.Ceps.Where(x => x.CepString == cep).FirstOrDefault();                
                }
                catch {
                    result.result = "Verifique se os dados realmente existem ou cheque sua conexão.";
                }
                return result;
            });

        }
    }
}