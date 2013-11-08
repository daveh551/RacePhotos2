// [[Highway.Onramp.MVC.Data]]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RacePhotos2.Entities.Mappings
{
    public class ExampleEntityMapping : BaseMapping<ExampleEntity>
    {
        public ExampleEntityMapping()
        {
            this.Property(e => e.Name).IsOptional();
        }
    }
}