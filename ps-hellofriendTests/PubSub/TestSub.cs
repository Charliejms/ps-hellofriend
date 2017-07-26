using ps_hellofriend.Controllers;
using PubSub;

namespace ps_hellofriendTests.TestSub
{
    public class TestSub
    {

        //Constructor 
        public TestSub() {
            //subcrito al envento de test diccionario de test
            this.Subscribe<HelloFriendController>( test => {
                var testing = test;
            });
        }

      
    }
}
