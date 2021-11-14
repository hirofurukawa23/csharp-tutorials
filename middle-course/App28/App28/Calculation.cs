namespace App28
{
    public static class Calculation
    {
        //単なる5
        private static int Five = 5;

        //常に5を加算するメソッド
        public static int AlwaysAddFive(int input)
        {
            return input + Five;
        }

        //常に5を乗算するメソッド
        public static int AlwaysMultiFive(int input)
        {
            return input * Five;
        }
    }
}
