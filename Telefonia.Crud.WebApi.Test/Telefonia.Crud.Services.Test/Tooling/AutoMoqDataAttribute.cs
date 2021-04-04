using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.NUnit3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telefonia.Crud.Services.Test.Tooling
{
    public class AutoMoqDataAttribute : AutoDataAttribute
    {
        public AutoMoqDataAttribute() : base(() =>
        {
            var fixture = new Fixture();
            fixture.Customize(new AutoMoqCustomization());

            fixture.Behaviors.OfType<ThrowingRecursionBehavior>().ToList().ForEach(_ => fixture.Behaviors.Remove(_));

            fixture.Behaviors.Add((new OmitOnRecursionBehavior()));

            return fixture;
        })
        {

        }
    }
}
