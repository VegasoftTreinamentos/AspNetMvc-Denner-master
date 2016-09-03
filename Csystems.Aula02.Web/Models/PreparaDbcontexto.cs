using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Csystems.Aula.Persistencia.Dados.SQLServer;
using Csystems.Aula02.Dominio.Entidades;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Csystems.Aula02.Web.Models
{
//    public class PreparaDbcontexto : DropCreateDatabaseAlways<ApplicationDbContext>


    public class PreparaDbcontexto : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
    //    protected  List<Cliente> clientes = new List<Cliente>();
        PdvDbContexto pdv = new PdvDbContexto();


        protected override void Seed(ApplicationDbContext contexto)
        {
            PopularBaseDados(contexto);
            PopulaCliente(pdv);
        }

        private void PopularBaseDados(ApplicationDbContext contexto)
        {
            try
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(contexto));
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(contexto));

                //popular papeis

                roleManager.Create((new IdentityRole("Admin")));
                roleManager.Create(new IdentityRole("Visitante"));
                roleManager.Create((new IdentityRole("Vendedor")));
                roleManager.Create(new IdentityRole("Gerente"));

                //popular usuarios
                var adm =new ApplicationUser() {UserName = "denner2013fcv@hotmail.com",Email = "denner2013fcv@hotmail.com" ,Cnpj = "00000000",Empresa = "01"};
                if ((userManager.Create(adm,"adm@2016")).Succeeded)
                {
                    userManager.AddToRole(adm.Id,"Admin");
                }

                var Visitante = new ApplicationUser() { UserName = "denner@hotmail.com", Email = "denner@hotmail.com", Cnpj = "00000000", Empresa = "01" };
                if ((userManager.Create(Visitante, "adm@2016")).Succeeded)
                {
                    userManager.AddToRole(Visitante.Id, "Visitante");
                }
                //populaclientes
               
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void PopulaCliente(PdvDbContexto contexto)
        {
            for (int i = 0; i < 1000; i++)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = Faker.Name.NomeCompleto();
                cliente.CPF = Faker.RandomNumber.Next(10000000).ToString();

                contexto.Clientes.Add(cliente);
            }
            contexto.SaveChanges();
        }
    }

    
}