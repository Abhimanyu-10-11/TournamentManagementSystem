namespace TrackerLibrary.Models
{
    public class PrizeModel
    {

        /// <summary>
        /// Unique Id for all prize.
        /// </summary>
        public int Id { get;  set; }
        /// <summary>
        /// Represents the name of prize ex: first,second and so on.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize in number ex: 1,2,3,....
        /// </summary>
        public int  PlaceNumber { get; set; }
        /// <summary>
        /// Represents prize amount for the prize number.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents precentage of amount form total amount for 
        /// prize.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {
            
        }
        public PrizeModel(string placeNumber,string placeName,string prizeAmount,string prizePercentage)
        {
            PlaceName = placeName;
             
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;


            decimal prizeAmountValue = 0;
            double prizePercentageValue = 0;

            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;


            double.TryParse(prizePercentage, out prizePercentageValue);
          PrizePercentage = prizePercentageValue;

        }


    }
}