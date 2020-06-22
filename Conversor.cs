namespace MetodoeAtributosEstaticos
{
    public static class Conversor
    {
        private static float CotacaoEuro = 5.9f;
        public static float EuroParaReal(float valorEU){
            return valorEU * CotacaoEuro;
        }
        public static float RealParaEuro(float valorRS){
            return  valorRS / CotacaoEuro;
        }


    }   
}