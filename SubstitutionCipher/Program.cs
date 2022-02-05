Dictionary<char, string> cipher1 = new()
{
    { 'A', "V" },
    { 'B', "U" },
    { 'C', "X" },
    { 'D', "W" },
    { 'E', "?" },
    { 'F', "Y" },
    { 'G', "B" },
    { 'H', "A" },
    { 'I', "D" },
    { 'J', "C" },
    { 'K', "F" },
    { 'L', "E" },
    { 'M', "H" },
    { 'N', "G" }, 
    { 'O', "I" }, // ?
    { 'P', "I" }, // ?
    { 'Q', "L" },
    { 'R', "K" },
    { 'S', "N" },
    { 'T', "M" },
    { 'U', "P" },
    { 'V', "O" },
    { 'W', "R" },
    { 'X', "Q" }, 
    { 'Y', "T" },
    { 'Z', "S" },
};

string hip290Message =
@"YMPZ PZ YVWXBHYBZ HGHSIVS DVWR VS LZYHGQPZMPSN H
SLD STQH KPNBWLMLHI SV LCPZYPSN JHSIPIHYLZ MHAL
ZBKKPJPLSY ZBUUVWY YV WLUQHJL YMLYH ZLALS MPZ
THWYFWIVT DHZ LCULJYLI GBY MHZ BSKVWYBSHYLQF
MHUULSLI HMLHI VK ZJMLIBQL KVW SVD JVSJLSYWHYL VS
HAVPIPSN ILYLJYPVS YMLWL DPQQ GL VYMLW JMHSJLZ YV
WLTVAL YML WLTHPSPSN IBAHQS";

Dictionary<char, string> cipher2 = new()
{
    // Cipher key 2 from Imperial Beacon
    { '1', "A" }, // ?
    { '2', "E" }, // ?
    { '3', "I" },
    { '4', "O" },
    { '5', "U" },
    { 'A', "?" }, // ?
    { 'B', "W" },
    { 'C', "V" },
    { 'D', "T" },
    { 'E', "?" }, // ?
    { 'F', "S" },
    { 'G', "R" },
    { 'H', "Q" },
    { 'I', "?" }, // ?
    { 'J', "P" },
    { 'K', "N" },
    { 'L', "M" },
    { 'M', "L" },
    { 'N', "K" },
    { 'P', "J" },
    { 'Q', "H" },
    { 'R', "G" },
    { 'S', "F" },
    { 'T', "D" },
    { 'U', "?" }, // ?
    { 'V', "C" },
    { 'W', "B" },
    { 'X', "?" }, // ?
    { 'Y', "Y" },
    { 'Z', "X" },
};


string saffronMessage =
@"5GF5M1 2DF 1MW2GD4 1R13K Y45 Q1C2 D4 Q2MJ L2 3C2
M2SD V1J3D4M B3DQ LY S1L3MY D4 1C43T 33FF
H52FD34K3KR BQ1D 3S DQ1D M1KT15 B4L1K G21MMY
V1K VG1VN 45G 4L2R1 RG3T N1GM JG4L3F2T L2 DQ1D B1F
3LJ4FF3WM2 Y45 NK4B 3C2 1MB1YF W22K M4Y1M D4 Y45
1KT DQ2 4DQ2G M4GTF W5D 3 K2C2G TG21LD 45G B4GN
V45MT 2ZJ4F2 L2 J2GF4K1MMY T4 F4L2DQ3KR";

Dictionary<char, string> cipher3 = new()
{
    // Cipher key 2 from Imperial Beacon
    { '1', "?" },
    { '2', "E" }, // or I or O
    { '3', "?" },
    { '4', "?" },
    { '5', "?" },
    { 'A', "?" },
    { 'B', "Y" }, // Given
    { 'C', "Z" }, // Given
    { 'D', "B" }, // Given
    { 'E', "?" },
    { 'F', "C" }, // or CH
    { 'G', "D" }, // Given
    { 'H', "F" },
    { 'I', "?" },
    { 'J', "G" },
    { 'K', "H" },
    { 'L', "J" }, // Given
    { 'M', "K" }, // Given
    { 'N', "L" },
    { 'P', "M" }, // Given
    { 'Q', "N" },
    { 'R', "QU" }, // Given
    { 'S', "R" }, // Given
    { 'T', "R" },
    { 'U', "?" },
    { 'V', "S" },
    { 'W', "T" }, // or TH
    { 'X', "V" },
    { 'Y', "W" },
    { 'Z', "X" }, // Given
};

string maidjinMessage =
@"F2N2Q2N DT2FM T2R2TW2QJ W2 V2Q2W2T Q2TX2 Y2X2
K2G W2 G2VD2QG WK2 T2P22Q2QJ WT22Q2QJ F2PRV PB
V2NG22TV F22JKW 2QG 2Z2F2W2G V2X2T2N 2FW 2J2QWV
2P2QJ WK2 N2W2VW 2QW2M2 2H B22 Y2QW 2V W2
F2QW2Q22 Y2TM2QJ H2T WK2 N2TGQ 2H T2VW2T2W22Q
Y2 P2VW T2Q2J2W22T2 22T 2JT22P2QW WK2 F2TT2QW
V2W22W22Q 2V Q2W V2VW22Q2DN2";

//Decode(hip290Message, cipher1);
//Console.WriteLine();
//DumpCipher(cipher1);
//Console.WriteLine();
//Decode(saffronMessage, cipher2);
//Console.WriteLine();
//DumpCipher(cipher2);
//Console.ReadLine();
Decode(maidjinMessage, cipher3);
Console.WriteLine();
//DumpCipher(cipher1);
//Console.WriteLine();

void Decode(string message, Dictionary<char, string> cipher)
{
    foreach (char c in message)
    {
        Console.Write(cipher.Keys.Contains(c) ? cipher[c] : c);
    }
}

void DumpCipher(Dictionary<char, string> cipher)
{
    foreach(char c in cipher.Keys.OrderBy(c => c))
    {
        Console.WriteLine($"{c} => {cipher[c]}");
    }
}

/* Output:
 
this is torquatus abandon work on establishing a
new nmla figurehead no existing candidates have
sufficient support to replace theta seven his
martyrdom was expected but has unfortunately
happened ahead of schedule for now concentrate on
avoiding detection there will be other chances to
remove the remaining duvaln

ursula ets alberto again you have to help me ive
left capitol with my family to avoid iiss
questioning what if that landau woman really
can crack our omega grid karl promised me that was
impossible you know ive always been loyal to you
and the other lords but i never dreamt our work
could expose me personally do something

CELENEL BRECK REQUERTENG TE SENETER NERVE WEVE
HED TE DESBEND THE REMEENENG TREENENG CEMQUS MY
SELDEERS CEEGHT END EXECETED SEVEREL ECT EGENTS
EMENG THE LETEST ENTEKE EF YEE WENT ES TE
CENTENEE WERKENG FER THE LERDN EF RESTERETEEN
WE MEST RENEGETEERE EER EGREEMENT THE CERRENT
SETEETEEN ES NET SESTEENEBLE

Translation:
Colonel BRECK (?) requesting to Senator Nerva. We've
had to disband the remaining training camps. My
soldiers caught and executed several ACT agents
among the latest intake. If you want us to
continue working for the lords of Restoration (?),
we must renegotiate our agreement. The current 
situation is not sustainable.

*/