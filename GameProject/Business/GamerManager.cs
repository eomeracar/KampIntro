using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        //MikroService
        IUserValidationService _userValidationService;
        private List<Gamer> _gamer;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
            _gamer = new List<Gamer>();
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt başarılı");
                _gamer.Add(gamer);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
            _gamer.Remove(gamer);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
        public List<Gamer> GetGamers()
        {
            return _gamer;
        }
       
    }
}
