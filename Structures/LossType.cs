
namespace Claims_Application.Structures
{
    //Structure to Represent Records in the Loss Types table
    public struct LossType
    {
        public int LossTypeID { get; set; }
        public string LossTypeCode { get; set; }
        public string LossTypeDescription { get; set; }

    }
}
