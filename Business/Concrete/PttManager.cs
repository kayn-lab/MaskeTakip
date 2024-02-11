using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {

     private   IApplicantService _applicantService;

        public PttManager(IApplicantService applicantservice) 
        {
            _applicantService = applicantservice;
        }

        public void GiveMask(Person person) 
        {
            PersonManager personManager = new PersonManager();
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " İçin maske verildi");
            }
            else 
            {
                Console.WriteLine( person.FirstName + " Maske verilemedi" );


            }
             
        
        
        
        }
    
    
    
    }
}
