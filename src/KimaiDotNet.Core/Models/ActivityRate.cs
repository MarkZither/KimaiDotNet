// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MarkZither.KimaiDotNet.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ActivityRate
    {
        /// <summary>
        /// Initializes a new instance of the ActivityRate class.
        /// </summary>
        public ActivityRate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityRate class.
        /// </summary>
        public ActivityRate(bool isFixed, int? id = default(int?), User user = default(User), double? rate = default(double?), double? internalRate = default(double?))
        {
            Id = id;
            User = user;
            Rate = rate;
            InternalRate = internalRate;
            IsFixed = isFixed;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public double? Rate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "internalRate")]
        public double? InternalRate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isFixed")]
        public bool IsFixed { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (User != null)
            {
                User.Validate();
            }
        }
    }
}
