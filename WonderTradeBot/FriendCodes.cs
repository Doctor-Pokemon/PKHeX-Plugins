﻿namespace WonderTradeBot
{
    public static class FriendCodes
    {
        public static readonly uint[] FCtable =
        {
            6, 16, 31, 61, 101, 151, 211, 281, 361,
            451, 551, 651, 751, 851, 951, 1051, 1151, 1251, 1351, 1451, 1571, 1691, 1811,
            1931, 2051, 2171, 2291, 2411, 2531, 2651, 2801, 2951, 3101, 3251, 3401, 3551,
            3701, 3851, 4001, 4151, 4331, 4511, 4691, 4871, 5051, 5231, 5411, 5591, 5771,
            5951, 6161, 6371, 6581, 6791, 7001, 7211, 7421, 7631, 7841, 8051, 8291, 8531,
            8771, 9011, 9251, 9491, 9731, 9971, 10211, 10451, 10721, 10991, 11261, 11531,
            11801, 12071, 12341, 12611, 12881, 13151, 13421, 13691, 13961, 14231, 14501,
            14771, 15041, 15311, 15581, 15851, 16121, 16391, 16661, 16931, 17201, 17471,
            17741, 18011, 18281, 18551, 18851, 19151, 19451, 19751, 20051, 20351, 20651,
            20951, 21251, 21551, 21851, 22151, 22451, 22751, 23051, 23351, 23651, 23951,
            24251, 24551, 24851, 25151, 25451, 25751, 26051, 26351, 26651, 26951, 27251,
            27551, 27851, 28151, 28451, 28751, 29051, 29351, 29651, 29951, 30251, 30551,
            30851, 31151, 31451, 31751, 32051, 32351, 32651, 32951, 33251, 33551, 33851,
            34151, 34451, 34751, 35051, 35351, 35651, 35951, 36251, 36551, 36851, 37151,
            37451, 37751, 38051, 38351, 38651, 38951, 39251, 39551, 39851, 40151, 40451,
            40751, 41051, 41351, 41651, 41951, 42251, 42551, 42851, 43151, 43451, 43751,
            44051, 44351, 44651, 44951, 45251, 45551, 45851, 46151, 46451, 46751, 47051,
            47351, 47651, 47951, 48251, 48551, 48851, 49151, 49451, 49751, 50051, 50351,
            50651, 50951, 51251, 51551, 51851, 52151, 52451, 52751, 53051, 53351, 53651,
            53951, 54251, 54551, 54851, 55151, 55451, 55751, 56051, 56351, 56651, 56951,
            57251, 57551, 57851, 58151, 58451, 58751, 59051, 59351, 59651, 59951, 60251,
            60551, 60851, 61151, 61451, 61751, 62051, 62351, 62651, 62951, 63251, 63551,
            63851, 64151, 64451, 64751, 65051, 65351, 65651, 65951, 66251, 66551, 66851,
            67151, 67451, 67751, 68051, 68351, 68651, 68951, 69251, 69551, 69851, 70151,
            70451, 70751, 71051, 71351, 71651, 71951, 72251, 72551, 72851, 73151, 73451,
            73751, 74051, 74351, 74651, 74951, 75251, 75551, 75851, 76151, 76451, 76751,
            77051, 77351, 77651, 77951, 78251, 78551, 78851, 79151, 79451, 79751, 80051,
            80351, 80651, 80951, 81251, 81551, 81851, 82151, 82451, 82751, 83051, 83351,
            83651, 83951, 84251, 84551, 84851, 85151, 85451, 85751, 86051, 86351, 86651,
            86951, 87251, 87551, 87851, 88151, 88451, 88751, 89051, 89351, 89651, 89951,
            90251, 90551, 90851, 91151, 91451, 91751, 92051, 92351, 92651, 92951, 93251,
            93551, 93851, 94151, 94451, 94751, 95051, 95351, 95651, 95951, 96251, 96551,
            96851, 97151, 97451, 97751, 98051, 98351, 98651, 98951, 99251, 99551, 99851,
            100151, 100451, 100751, 101051, 101351, 101651, 101951, 102251, 102551,
            102851, 103151, 103451, 103751, 104051, 104351, 104651, 104951, 105251,
            105551, 105851, 106151, 106451, 106751, 107051, 107351, 107651, 107951,
            108251, 108551, 108851, 109151, 109451, 109751, 110051, 110351, 110651,
            110951, 111251, 111551, 111851, 112151, 112451, 112751, 113051, 113351,
            113651, 113951, 114251, 114551, 114851, 115151, 115451, 115751, 116051,
            116351, 116651, 116951, 117251, 117551, 117851, 118151, 118451, 118751,
            119051, 119351, 119651, 119951, 120251, 120551, 120851, 121151, 121451,
            121751, 122051, 122351, 122651, 122951, 123251, 123551, 123851, 124151,
            124451, 124751, 125051, 125351, 125651, 125951, 126251, 126551, 126851,
            127151, 127451, 127751, 128051, 128351, 128651, 128951, 129251, 129551,
            129851, 130151, 130451, 130751, 131051, 131351, 131651, 131951, 132251,
            132551, 132851, 133151, 133451, 133751, 134051, 134351, 134651, 134951,
            135251, 135551, 135851, 136151, 136451, 136751, 137051, 137351, 137651,
            137951, 138251, 138551, 138851, 139151, 139451, 139751, 140051, 140351,
            140651, 140951, 141251, 141551, 141851, 142151, 142451, 142751, 143051,
            143351, 143651, 143951, 144251, 144551, 144851, 145151, 145451, 145751,
            146051, 146351, 146651, 146951, 147251, 147551, 147851, 148151, 148451,
            148751, 149051, 149351, 149651, 149951, 150251, 150551, 150851, 151151,
            151451, 151751, 152051, 152351, 152651, 152951, 153251, 153551, 153851,
            154151, 154451, 154751, 155051, 155351, 155651, 155951, 156251, 156551,
            156851, 157151, 157451, 157751, 158051, 158351, 158651, 158951, 159251,
            159551, 159851, 160151, 160451, 160751, 161051, 161351, 161651, 161951,
            162251, 162551, 162851, 163151, 163451, 163751, 164051, 164351, 164651,
            164951, 165251, 165551, 165851, 166151, 166451, 166751, 167051, 167351,
            167651, 167951, 168251, 168551, 168851, 169151, 169451, 169751, 170051,
            170351, 170651, 170951, 171251, 171551, 171851, 172151, 172451, 172751,
            173051, 173351, 173651, 173951, 174251, 174551, 174851, 175151, 175451,
            175751, 176051, 176351, 176651, 176951, 177251, 177551, 177851, 178151,
            178451, 178751, 179051, 179351, 179651, 179951, 180251, 180551, 180851,
            181151, 181451, 181751, 182051, 182351, 182651, 182951, 183251, 183551,
            183851, 184151, 184451, 184751, 185051, 185351, 185651, 185951, 186251,
            186551, 186851, 187151, 187451, 187751, 188051, 188351, 188651, 188951,
            189251, 189551, 189851, 190151, 190451, 190751, 191051, 191351, 191651,
            191951, 192251, 192551, 192851, 193151, 193451, 193751, 194051, 194351,
            194651, 194951, 195251, 195551, 195851, 196151, 196451, 196751, 197051,
            197351, 197651, 197951, 198251, 198551, 198851, 199151, 199451, 199751,
            200051, 200351, 200651, 200951, 201251, 201551, 201851, 202151, 202451,
            202751, 203051, 203351, 203651, 203951, 204251, 204551, 204851, 205151,
            205451, 205751, 206051, 206351, 206651, 206951, 207251, 207551, 207851,
            208151, 208451, 208751, 209051, 209351, 209651, 209951, 210251, 210551,
            210851, 211151, 211451, 211751, 212051, 212351, 212651, 212951, 213251,
            213551, 213851, 214151, 214451, 214751, 215051, 215351, 215651, 215951,
            216251, 216551, 216851, 217151, 217451, 217751, 218051, 218351, 218651,
            218951, 219251, 219551, 219851, 220151, 220451, 220751, 221051, 221351,
            221651, 221951, 222251, 222551, 222851, 223151, 223451, 223751, 224051,
            224351, 224651, 224951, 225251, 225551, 225851, 226151, 226451, 226751,
            227051, 227351, 227651, 227951, 228251, 228551, 228851, 229151, 229451,
            229751, 230051, 230351, 230651, 230951, 231251, 231551, 231851, 232151,
            232451, 232751, 233051, 233351, 233651, 233951, 234251, 234551, 234851,
            235151, 235451, 235751, 236051, 236351, 236651, 236951, 237251, 237551,
            237851, 238151, 238451, 238751, 239051, 239351, 239651, 239951, 240251,
            240551, 240851, 241151, 241451, 241751, 242051, 242351, 242651, 242951,
            243251, 243551, 243851, 244151, 244451, 244751, 245051, 245351, 245651,
            245951, 246251, 246551, 246851, 247151, 247451, 247751, 248051, 248351,
            248651, 248951, 249251, 249551, 249851, 250151, 250451, 250751, 251051,
            251351, 251651, 251951, 252251, 252551, 252851, 253151, 253451, 253751,
            254051, 254351, 254651, 254951, 255251, 255551, 255851, 256151, 256451,
            256751, 257051, 257351, 257651, 257951, 258251, 258551, 258851, 259151,
            259451, 259751, 260051, 260351, 260651, 260951, 261251, 261551, 261851,
            262151, 262451, 262751, 263051, 263351, 263651, 263951, 264251, 264551,
            264851, 265151, 265451, 265751, 266051, 266351, 266651, 266951, 267251,
            267551, 267851, 268151, 268451, 268751, 269051, 269351, 269651, 269951,
            270251, 270551, 270851, 271151, 271451, 271751, 272051, 272351, 272651,
            272951, 273251, 273551, 273851, 274151, 274451, 274751, 275051, 275351,
            275651, 275951, 276251, 276551, 276851, 277151, 277451, 277751, 278051,
            278351, 278651, 278951, 279251, 279551, 279851, 280151, 280451, 280751,
            281051, 281351, 281651, 281951, 282251, 282551, 282851, 283151, 283451,
            283751, 284051, 284351, 284651, 284951, 285251, 285551, 285851, 286151,
            286451, 286751, 287051, 287351, 287651, 287951, 288251
        };
    }
}
