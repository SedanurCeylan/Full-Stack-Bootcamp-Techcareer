using BACKEND.Basic.Models;

namespace Basic.Models{
     
    public class Repository{
        private static readonly List<Bootcamp> _bootcamps = new();

        static Repository(){
            _bootcamps = new List<Bootcamp>(){

                new Bootcamp() {id=1,
                                Description="ff2", 
                                Title="haha2",
                                Image="1.png",
                                Tags= new string[]{"Html","Web Geliştirme"},
                                isActive=true,
                                isHome=true},
                new Bootcamp() {id=2, 
                                Description="ff3", 
                                Title="haha3", 
                                Image="2.png",
                                Tags= new string[]{"Game","Web Geliştirme"},
                                isActive=true,
                                isHome=false},
                new Bootcamp() {id=3, 
                                Description="ff4", 
                                 Title="haha4", 
                                Image="3.png",
                                Tags= new string[]{"asp.net","Web Geliştirme"},
                                isActive=false,
                                isHome=false}

            };
        }


        public static List<Bootcamp> Bootcamps{
            get{
                return _bootcamps;
            }
        }

        public static Bootcamp? GetById(int? id){
            return _bootcamps.FirstOrDefault(b=>b.id == id);
        }
    }



}