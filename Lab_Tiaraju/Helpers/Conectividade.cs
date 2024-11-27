namespace Lab_Tiaraju.Helpers
{
    public class Conectividade
    {
        public static bool VerificaConectividade()
        {
            bool HasConectivity = false;
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                HasConectivity = true;
            }

            return HasConectivity;
        }

    }
}
