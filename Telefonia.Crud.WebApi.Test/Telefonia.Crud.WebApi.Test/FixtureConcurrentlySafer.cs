using AutoFixture;
using System.Linq;

namespace Telefonia.Crud.WebApi.Test
{
    public static class FixtureConcurrentlySafer
    {
        public static Fixture New()
        {
            var fixture = new Fixture();
            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(_ => fixture.Behaviors.Remove(_));
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());

            return fixture;

        }
        

    }
}
