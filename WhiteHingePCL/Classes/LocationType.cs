namespace WhiteHingePCL.Classes
{
    public partial class LocationData
    {
        /// <summary>
        /// An enum used to describe the location type of the location
        /// </summary>
        public enum LocationType
        {
            /// <summary>
            /// Unused Location. This indicates an error with the location
            /// </summary>
            Unused = -1,
            /// <summary>
            /// Storage Locations
            /// </summary>
            Storage = 0,
            /// <summary>
            /// Pickable locations
            /// </summary>
            Pickable = 1,
            /// <summary>
            /// Prepack storage
            /// </summary>
            Prepack = 2,
            /// <summary>
            /// Delivery Storage
            /// </summary>
            Delivery = 3,
            /// <summary>
            /// Priority Prepack Locations
            /// </summary>
            PrepackInstant = 4,
            /// <summary>
            /// Items which have been transformed in Prepack
            /// </summary>
            PrepackComplete = 5,
            /// <summary>
            /// Damaged Items
            /// </summary>
            Damaged = 6,
            /// <summary>
            /// Items which have lost their locations
            /// </summary>
            Lost = 7,
            /// <summary>
            /// Returned items
            /// </summary>
            Returns = 8
        }
    }
}
