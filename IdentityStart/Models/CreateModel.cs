using FluentValidation.Attributes;
using ApplyIdentity.Infrastructure;

namespace ApplyIdentity.Models
{
    [Validator(typeof(FluentCreateModelValidator))]
    public class CreateModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}