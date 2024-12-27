/* Rules:
    Symbol       Value
    I             1
    V             5
    X             10
    L             50
    C             100
    D             500
    M             1000

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

    I can be added to next until III. Number 4 will be as IV.
    V cannot be twice in the same number
*/

Console.WriteLine(Solution.RomanToInt("I") == 1 ? "I = 1 (expected 1)" : "ERROR: I = " + Solution.RomanToInt("I") + ", but expected 1");
Console.WriteLine(Solution.RomanToInt("II") == 2 ? "II = 2 (expected 2)" : "ERROR: II = " + Solution.RomanToInt("II") + ", but expected 2");
Console.WriteLine(Solution.RomanToInt("III") == 3 ? "III = 3 (expected 3)" : "ERROR: III = " + Solution.RomanToInt("III") + ", but expected 3");
Console.WriteLine(Solution.RomanToInt("IV") == 4 ? "IV = 4 (expected 4)" : "ERROR: IV = " + Solution.RomanToInt("IV") + ", but expected 4");
Console.WriteLine(Solution.RomanToInt("V") == 5 ? "V = 5 (expected 5)" : "ERROR: V = " + Solution.RomanToInt("V") + ", but expected 5");
Console.WriteLine(Solution.RomanToInt("VI") == 6 ? "VI = 6 (expected 6)" : "ERROR: VI = " + Solution.RomanToInt("VI") + ", but expected 6");
Console.WriteLine(Solution.RomanToInt("VII") == 7 ? "VII = 7 (expected 7)" : "ERROR: VII = " + Solution.RomanToInt("VII") + ", but expected 7");
Console.WriteLine(Solution.RomanToInt("VIII") == 8 ? "VIII = 8 (expected 8)" : "ERROR: VIII = " + Solution.RomanToInt("VIII") + ", but expected 8");
Console.WriteLine(Solution.RomanToInt("IX") == 9 ? "IX = 9 (expected 9)" : "ERROR: IX = " + Solution.RomanToInt("IX") + ", but expected 9");
Console.WriteLine(Solution.RomanToInt("X") == 10 ? "X = 10 (expected 10)" : "ERROR: X = " + Solution.RomanToInt("X") + ", but expected 10");
Console.WriteLine(Solution.RomanToInt("XI") == 11 ? "XI = 11 (expected 11)" : "ERROR: XI = " + Solution.RomanToInt("XI") + ", but expected 11");
Console.WriteLine(Solution.RomanToInt("XII") == 12 ? "XII = 12 (expected 12)" : "ERROR: XII = " + Solution.RomanToInt("XII") + ", but expected 12");
Console.WriteLine(Solution.RomanToInt("XIII") == 13 ? "XIII = 13 (expected 13)" : "ERROR: XIII = " + Solution.RomanToInt("XIII") + ", but expected 13");
Console.WriteLine(Solution.RomanToInt("XIV") == 14 ? "XIV = 14 (expected 14)" : "ERROR: XIV = " + Solution.RomanToInt("XIV") + ", but expected 14");
Console.WriteLine(Solution.RomanToInt("XV") == 15 ? "XV = 15 (expected 15)" : "ERROR: XV = " + Solution.RomanToInt("XV") + ", but expected 15");
Console.WriteLine(Solution.RomanToInt("XVI") == 16 ? "XVI = 16 (expected 16)" : "ERROR: XVI = " + Solution.RomanToInt("XVI") + ", but expected 16");
Console.WriteLine(Solution.RomanToInt("XVII") == 17 ? "XVII = 17 (expected 17)" : "ERROR: XVII = " + Solution.RomanToInt("XVII") + ", but expected 17");
Console.WriteLine(Solution.RomanToInt("XVIII") == 18 ? "XVIII = 18 (expected 18)" : "ERROR: XVIII = " + Solution.RomanToInt("XVIII") + ", but expected 18");
Console.WriteLine(Solution.RomanToInt("XIX") == 19 ? "XIX = 19 (expected 19)" : "ERROR: XIX = " + Solution.RomanToInt("XIX") + ", but expected 19");
Console.WriteLine(Solution.RomanToInt("XX") == 20 ? "XX = 20 (expected 20)" : "ERROR: XX = " + Solution.RomanToInt("XX") + ", but expected 20");
Console.WriteLine(Solution.RomanToInt("XXX") == 30 ? "XXX = 30 (expected 30)" : "ERROR: XXX = " + Solution.RomanToInt("XXX") + ", but expected 30");
Console.WriteLine(Solution.RomanToInt("XL") == 40 ? "XL = 40 (expected 40)" : "ERROR: XL = " + Solution.RomanToInt("XL") + ", but expected 40");
Console.WriteLine(Solution.RomanToInt("L") == 50 ? "L = 50 (expected 50)" : "ERROR: L = " + Solution.RomanToInt("L") + ", but expected 50");
Console.WriteLine(Solution.RomanToInt("LX") == 60 ? "LX = 60 (expected 60)" : "ERROR: LX = " + Solution.RomanToInt("LX") + ", but expected 60");
Console.WriteLine(Solution.RomanToInt("LXX") == 70 ? "LXX = 70 (expected 70)" : "ERROR: LXX = " + Solution.RomanToInt("LXX") + ", but expected 70");
Console.WriteLine(Solution.RomanToInt("LXXX") == 80 ? "LXXX = 80 (expected 80)" : "ERROR: LXXX = " + Solution.RomanToInt("LXXX") + ", but expected 80");
Console.WriteLine(Solution.RomanToInt("XC") == 90 ? "XC = 90 (expected 90)" : "ERROR: XC = " + Solution.RomanToInt("XC") + ", but expected 90");
Console.WriteLine(Solution.RomanToInt("C") == 100 ? "C = 100 (expected 100)" : "ERROR: C = " + Solution.RomanToInt("C") + ", but expected 100");
Console.WriteLine(Solution.RomanToInt("CX") == 110 ? "CX = 110 (expected 110)" : "ERROR: CX = " + Solution.RomanToInt("CX") + ", but expected 110");
Console.WriteLine(Solution.RomanToInt("CXX") == 120 ? "CXX = 120 (expected 120)" : "ERROR: CXX = " + Solution.RomanToInt("CXX") + ", but expected 120");
Console.WriteLine(Solution.RomanToInt("CXXX") == 130 ? "CXXX = 130 (expected 130)" : "ERROR: CXXX = " + Solution.RomanToInt("CXXX") + ", but expected 130");
Console.WriteLine(Solution.RomanToInt("CXL") == 140 ? "CXL = 140 (expected 140)" : "ERROR: CXL = " + Solution.RomanToInt("CXL") + ", but expected 140");
Console.WriteLine(Solution.RomanToInt("CL") == 150 ? "CL = 150 (expected 150)" : "ERROR: CL = " + Solution.RomanToInt("CL") + ", but expected 150");
Console.WriteLine(Solution.RomanToInt("CLX") == 160 ? "CLX = 160 (expected 160)" : "ERROR: CLX = " + Solution.RomanToInt("CLX") + ", but expected 160");
Console.WriteLine(Solution.RomanToInt("CLXX") == 170 ? "CLXX = 170 (expected 170)" : "ERROR: CLXX = " + Solution.RomanToInt("CLXX") + ", but expected 170");
Console.WriteLine(Solution.RomanToInt("CLXXX") == 180 ? "CLXXX = 180 (expected 180)" : "ERROR: CLXXX = " + Solution.RomanToInt("CLXXX") + ", but expected 180");
Console.WriteLine(Solution.RomanToInt("CXC") == 190 ? "CXC = 190 (expected 190)" : "ERROR: CXC = " + Solution.RomanToInt("CXC") + ", but expected 190");
Console.WriteLine(Solution.RomanToInt("CC") == 200 ? "CC = 200 (expected 200)" : "ERROR: CC = " + Solution.RomanToInt("CC") + ", but expected 200");
Console.WriteLine(Solution.RomanToInt("CCC") == 300 ? "CCC = 300 (expected 300)" : "ERROR: CCC = " + Solution.RomanToInt("CCC") + ", but expected 300");
Console.WriteLine(Solution.RomanToInt("CD") == 400 ? "CD = 400 (expected 400)" : "ERROR: CD = " + Solution.RomanToInt("CD") + ", but expected 400");
Console.WriteLine(Solution.RomanToInt("D") == 500 ? "D = 500 (expected 500)" : "ERROR: D = " + Solution.RomanToInt("D") + ", but expected 500");
Console.WriteLine(Solution.RomanToInt("DC") == 600 ? "DC = 600 (expected 600)" : "ERROR: DC = " + Solution.RomanToInt("DC") + ", but expected 600");
Console.WriteLine(Solution.RomanToInt("DCC") == 700 ? "DCC = 700 (expected 700)" : "ERROR: DCC = " + Solution.RomanToInt("DCC") + ", but expected 700");
Console.WriteLine(Solution.RomanToInt("DCCC") == 800 ? "DCCC = 800 (expected 800)" : "ERROR: DCCC = " + Solution.RomanToInt("DCCC") + ", but expected 800");
Console.WriteLine(Solution.RomanToInt("CM") == 900 ? "CM = 900 (expected 900)" : "ERROR: CM = " + Solution.RomanToInt("CM") + ", but expected 900");
Console.WriteLine(Solution.RomanToInt("M") == 1000 ? "M = 1000 (expected 1000)" : "ERROR: M = " + Solution.RomanToInt("M") + ", but expected 1000");
Console.WriteLine(Solution.RomanToInt("MC") == 1100 ? "MC = 1100 (expected 1100)" : "ERROR: MC = " + Solution.RomanToInt("MC") + ", but expected 1100");
Console.WriteLine(Solution.RomanToInt("MCC") == 1200 ? "MCC = 1200 (expected 1200)" : "ERROR: MCC = " + Solution.RomanToInt("MCC") + ", but expected 1200");
Console.WriteLine(Solution.RomanToInt("MCCC") == 1300 ? "MCCC = 1300 (expected 1300)" : "ERROR: MCCC = " + Solution.RomanToInt("MCCC") + ", but expected 1300");
Console.WriteLine(Solution.RomanToInt("MCD") == 1400 ? "MCD = 1400 (expected 1400)" : "ERROR: MCD = " + Solution.RomanToInt("MCD") + ", but expected 1400");
Console.WriteLine(Solution.RomanToInt("MD") == 1500 ? "MD = 1500 (expected 1500)" : "ERROR: MD = " + Solution.RomanToInt("MD") + ", but expected 1500");
Console.WriteLine(Solution.RomanToInt("MDC") == 1600 ? "MDC = 1600 (expected 1600)" : "ERROR: MDC = " + Solution.RomanToInt("MDC") + ", but expected 1600");
Console.WriteLine(Solution.RomanToInt("MDCC") == 1700 ? "MDCC = 1700 (expected 1700)" : "ERROR: MDCC = " + Solution.RomanToInt("MDCC") + ", but expected 1700");
Console.WriteLine(Solution.RomanToInt("MDCCC") == 1800 ? "MDCCC = 1800 (expected 1800)" : "ERROR: MDCCC = " + Solution.RomanToInt("MDCCC") + ", but expected 1800");
Console.WriteLine(Solution.RomanToInt("MCM") == 1900 ? "MCM = 1900 (expected 1900)" : "ERROR: MCM = " + Solution.RomanToInt("MCM") + ", but expected 1900");
Console.WriteLine(Solution.RomanToInt("MM") == 2000 ? "MM = 2000 (expected 2000)" : "ERROR: MM = " + Solution.RomanToInt("MM") + ", but expected 2000");
Console.WriteLine(Solution.RomanToInt("MMX") == 2010 ? "MMX = 2010 (expected 2010)" : "ERROR: MMX = " + Solution.RomanToInt("MMX") + ", but expected 2010");
Console.WriteLine(Solution.RomanToInt("MMXX") == 2020 ? "MMXX = 2020 (expected 2020)" : "ERROR: MMXX = " + Solution.RomanToInt("MMXX") + ", but expected 2020");
Console.WriteLine(Solution.RomanToInt("MMXXX") == 2030 ? "MMXXX = 2030 (expected 2030)" : "ERROR: MMXXX = " + Solution.RomanToInt("MMXXX") + ", but expected 2030");
Console.WriteLine(Solution.RomanToInt("MMXL") == 2040 ? "MMXL = 2040 (expected 2040)" : "ERROR: MMXL = " + Solution.RomanToInt("MMXL") + ", but expected 2040");
Console.WriteLine(Solution.RomanToInt("MML") == 2050 ? "MML = 2050 (expected 2050)" : "ERROR: MML = " + Solution.RomanToInt("MML") + ", but expected 2050");
Console.WriteLine(Solution.RomanToInt("MMLX") == 2060 ? "MMLX = 2060 (expected 2060)" : "ERROR: MMLX = " + Solution.RomanToInt("MMLX") + ", but expected 2060");
Console.WriteLine(Solution.RomanToInt("MMLXX") == 2070 ? "MMLXX = 2070 (expected 2070)" : "ERROR: MMLXX = " + Solution.RomanToInt("MMLXX") + ", but expected 2070");
Console.WriteLine(Solution.RomanToInt("MMLXXX") == 2080 ? "MMLXXX = 2080 (expected 2080)" : "ERROR: MMLXXX = " + Solution.RomanToInt("MMLXXX") + ", but expected 2080");
Console.WriteLine(Solution.RomanToInt("MMXC") == 2090 ? "MMXC = 2090 (expected 2090)" : "ERROR: MMXC = " + Solution.RomanToInt("MMXC") + ", but expected 2090");
Console.WriteLine(Solution.RomanToInt("MMC") == 2100 ? "MMC = 2100 (expected 2100)" : "ERROR: MMC = " + Solution.RomanToInt("MMC") + ", but expected 2100");
Console.WriteLine(Solution.RomanToInt("MMCC") == 2200 ? "MMCC = 2200 (expected 2200)" : "ERROR: MMCC = " + Solution.RomanToInt("MMCC") + ", but expected 2200");
Console.WriteLine(Solution.RomanToInt("MMCCC") == 2300 ? "MMCCC = 2300 (expected 2300)" : "ERROR: MMCCC = " + Solution.RomanToInt("MMCCC") + ", but expected 2300");
Console.WriteLine(Solution.RomanToInt("MMCD") == 2400 ? "MMCD = 2400 (expected 2400)" : "ERROR: MMCD = " + Solution.RomanToInt("MMCD") + ", but expected 2400");
Console.WriteLine(Solution.RomanToInt("MMD") == 2500 ? "MMD = 2500 (expected 2500)" : "ERROR: MMD = " + Solution.RomanToInt("MMD") + ", but expected 2500");

Console.WriteLine(Solution.RomanToInt("MMDC") == 2600 ? "MMDC = 2600 (expected 2600)" : "ERROR: MMDC = " + Solution.RomanToInt("MMDC") + ", but expected 2600");
Console.WriteLine(Solution.RomanToInt("MMDCC") == 2700 ? "MMDCC = 2700 (expected 2700)" : "ERROR: MMDCC = " + Solution.RomanToInt("MMDCC") + ", but expected 2700");
Console.WriteLine(Solution.RomanToInt("MMDCCC") == 2800 ? "MMDCCC = 2800 (expected 2800)" : "ERROR: MMDCCC = " + Solution.RomanToInt("MMDCCC") + ", but expected 2800");
Console.WriteLine(Solution.RomanToInt("MMCM") == 2900 ? "MMCM = 2900 (expected 2900)" : "ERROR: MMCM = " + Solution.RomanToInt("MMCM") + ", but expected 2900");
Console.WriteLine(Solution.RomanToInt("MMM") == 3000 ? "MMM = 3000 (expected 3000)" : "ERROR: MMM = " + Solution.RomanToInt("MMM") + ", but expected 3000");







Console.ReadLine();

public static class Solution
{
    public static int RomanToInt(string s)
    {
        var ret = 0;
        var arr = s.ToArray();
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            switch (arr[i])
            {
                case 'I':
                    ret += CalculateComplex(ret, arr, i, 'V', 'X', RomanNumeral.I, 1);
                    break;
                case 'V':
                    ret += (int)RomanNumeral.V;
                    break;
                case 'X':
                    ret += CalculateComplex(ret, arr, i, 'L', 'C', RomanNumeral.X, 10);
                    break;
                case 'L':
                    ret += (int)RomanNumeral.L;
                    break;
                case 'C':
                    ret += CalculateComplex(ret, arr, i,'D', 'M', RomanNumeral.C, 100);
                    break;
                case 'D':
                    ret += (int)RomanNumeral.D;
                    break;
                case 'M':
                    ret += (int)RomanNumeral.M;
                    break;
                default:
                    break;
            }
        }

        return ret;
    }

    private static int CalculateComplex(int ret, char[] arr, int i, char first, char second, RomanNumeral expected, int incremental)
    {
        var prevC = i > 0 ? arr[i - 1] : '\0';
        var nextC = i < arr.Length - 1 ? arr[i + 1] : '\0';
        // Conditions
        var isNextFirst = nextC == first;
        var isPrevFirst = prevC == first;
        var isPrevSecond = prevC == second;
        var isNextSecond = nextC == second;
        ret = (isNextFirst, isPrevFirst, isPrevSecond, isNextSecond, i >= 0, i != arr.Length - 1) switch
        {
            (true, _, _, _, true, true) => -incremental,
            (_, true, _, _, true, _) => incremental,
            (_, _, true, false, true, true) => incremental,
            (_, _, _, true, true, true) => -incremental,
            _ => (int)expected
        };
        return ret;
    }


}


public enum RomanNumeral
{
    I = 1,
    V = 5,
    X = 10,
    L = 50,
    C = 100,
    D = 500,
    M = 1000
}

