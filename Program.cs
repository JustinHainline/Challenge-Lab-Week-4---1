namespace Challenge_Lab_Week_4___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customerId;
            int consumedUnits;
            double charge;
            double surcharge = 0;
            double grossAmount;
            double netAmount;
            string customerName;

            Console.WriteLine("Calculate Electricity Bill:");
            Console.WriteLine();
            Console.WriteLine("----------------------------");

            Console.WriteLine("Input Customer ID: ");
            customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the name of the customer: ");
            customerName = Console.ReadLine();

            Console.WriteLine("Input the unit consumed by the customer: ");
            consumedUnits = Convert.ToInt32(Console.ReadLine());

            // Determine the charge based on consumed units
            if (consumedUnits < 200)
                charge = 1.20;
            else if (consumedUnits >= 200 && consumedUnits < 400)
                charge = 1.50;
            else if (consumedUnits >= 400 && consumedUnits < 600)
                charge = 1.80;
            else
                charge = 2.00;

            grossAmount = consumedUnits * charge; // Calculate gross amount

            if (grossAmount > 400)
                surcharge = grossAmount * 0.15; // Calculate surcharge if the gross amount exceeds $400

            netAmount = grossAmount + surcharge; // Calculate net amount

            if (netAmount < 100)
                netAmount = 100; // Set minimum net amount as $100

            // Print electricity bill details
            Console.WriteLine("\nElectricity Bill");
            Console.WriteLine($"Customer IDNO: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Unit Consumed: {consumedUnits}");
            Console.WriteLine($"Amount Charges @ $ {charge:F2} per unit: {grossAmount:F2}");
            Console.WriteLine($"Surcharge Amount: {surcharge:F2}");
            Console.WriteLine($"Net Amount Paid By the Customer: {netAmount:F2}");
        }
    }
    
}