using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA_MP_Vehicle_List
{
    public partial class Form_Main : Form
    {
        List<Class_Vehicle> List_Vehicles = new List<Class_Vehicle>();
        public static List<Class_Vehicle> Temp_VL = new List<Class_Vehicle>();
        int _index = 0;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            List_Vehicles.Add(new Class_Vehicle(400, "landstal", "Car", "null", "Normal", Properties.Resources.Vehicle_400));
            List_Vehicles.Add(new Class_Vehicle(401, "bravura", "Car", "null", "Poor Family", Properties.Resources.Vehicle_401));
            List_Vehicles.Add(new Class_Vehicle(402, "buffalo", "Car", "null", "Executive", Properties.Resources.Vehicle_402));
            List_Vehicles.Add(new Class_Vehicle(403, "linerun", "Car", "truck", "Worker", Properties.Resources.Vehicle_403));
            List_Vehicles.Add(new Class_Vehicle(404, "peren", "Car", "null", "Poor Family", Properties.Resources.Vehicle_404));
            List_Vehicles.Add(new Class_Vehicle(405, "sentinel", "Car", "null", "Rich Family", Properties.Resources.Vehicle_405));
            List_Vehicles.Add(new Class_Vehicle(406, "dumper", "Monster Truck", "truck", "Worker", Properties.Resources.Vehicle_406));
            List_Vehicles.Add(new Class_Vehicle(407, "firetruk", "Car", "truck", "Ignore", Properties.Resources.Vehicle_407));
            List_Vehicles.Add(new Class_Vehicle(408, "trash", "Car", "null", "Worker", Properties.Resources.Vehicle_408));
            List_Vehicles.Add(new Class_Vehicle(409, "stretch", "Car", "null", "Executive", Properties.Resources.Vehicle_409));
            List_Vehicles.Add(new Class_Vehicle(410, "manana", "Car", "null", "Poor Family", Properties.Resources.Vehicle_410));
            List_Vehicles.Add(new Class_Vehicle(411, "infernus", "Car", "null", "Executive", Properties.Resources.Vehicle_411));
            List_Vehicles.Add(new Class_Vehicle(412, "voodoo", "Car", "null", "Poor Family", Properties.Resources.Vehicle_412));
            List_Vehicles.Add(new Class_Vehicle(413, "pony", "Car", "van", "Worker", Properties.Resources.Vehicle_413));
            List_Vehicles.Add(new Class_Vehicle(414, "mule", "Car", "null", "Worker", Properties.Resources.Vehicle_414));
            List_Vehicles.Add(new Class_Vehicle(415, "cheetah", "Car", "null", "Executive", Properties.Resources.Vehicle_415));
            List_Vehicles.Add(new Class_Vehicle(416, "ambulan", "Car", "van", "Ignore", Properties.Resources.Vehicle_416));
            List_Vehicles.Add(new Class_Vehicle(417, "leviathn", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_417));
            List_Vehicles.Add(new Class_Vehicle(418, "moonbeam", "Car", "null", "Normal", Properties.Resources.Vehicle_418));
            List_Vehicles.Add(new Class_Vehicle(419, "esperant", "Car", "null", "Normal", Properties.Resources.Vehicle_419));
            List_Vehicles.Add(new Class_Vehicle(420, "taxi", "Car", "null", "Taxi", Properties.Resources.Vehicle_420));
            List_Vehicles.Add(new Class_Vehicle(421, "washing", "Car", "null", "Rich Family", Properties.Resources.Vehicle_421));
            List_Vehicles.Add(new Class_Vehicle(422, "bobcat", "Car", "null", "Worker", Properties.Resources.Vehicle_422));
            List_Vehicles.Add(new Class_Vehicle(423, "mrwhoop", "Car", "null", "Worker", Properties.Resources.Vehicle_423));
            List_Vehicles.Add(new Class_Vehicle(424, "bfinject", "Car", "BF_injectio", "Executive", Properties.Resources.Vehicle_424));
            List_Vehicles.Add(new Class_Vehicle(425, "hunter", "Helicopter", "rustler", "Ignore", Properties.Resources.Vehicle_425));
            List_Vehicles.Add(new Class_Vehicle(426, "premier", "Car", "null", "Rich Family", Properties.Resources.Vehicle_426));
            List_Vehicles.Add(new Class_Vehicle(427, "enforcer", "Car", "van", "Ignore", Properties.Resources.Vehicle_427));
            List_Vehicles.Add(new Class_Vehicle(428, "securica", "Car", "van", "Big", Properties.Resources.Vehicle_428));
            List_Vehicles.Add(new Class_Vehicle(429, "banshee", "Car", "null", "Executive", Properties.Resources.Vehicle_429));
            List_Vehicles.Add(new Class_Vehicle(430, "predator", "Boat", "null", "Ignore", Properties.Resources.Vehicle_430));
            List_Vehicles.Add(new Class_Vehicle(431, "bus", "Car", "bus", "Normal", Properties.Resources.Vehicle_431));
            List_Vehicles.Add(new Class_Vehicle(432, "rhino", "Car", "tank", "Ignore", Properties.Resources.Vehicle_432));
            List_Vehicles.Add(new Class_Vehicle(433, "barracks", "Car", "truck", "Ignore", Properties.Resources.Vehicle_433));
            List_Vehicles.Add(new Class_Vehicle(434, "hotknife", "Car", "null", "Executive", Properties.Resources.Vehicle_434));
            List_Vehicles.Add(new Class_Vehicle(435, "artict1", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_435));
            List_Vehicles.Add(new Class_Vehicle(436, "previon", "Car", "null", "Poor Family", Properties.Resources.Vehicle_436));
            List_Vehicles.Add(new Class_Vehicle(437, "coach", "Car", "coach", "Normal", Properties.Resources.Vehicle_437));
            List_Vehicles.Add(new Class_Vehicle(438, "cabbie", "Car", "null", "Taxi", Properties.Resources.Vehicle_438));
            List_Vehicles.Add(new Class_Vehicle(439, "stallion", "Car", "null", "Poor Family", Properties.Resources.Vehicle_439));
            List_Vehicles.Add(new Class_Vehicle(440, "rumpo", "Car", "van", "Poor Family", Properties.Resources.Vehicle_440));
            List_Vehicles.Add(new Class_Vehicle(441, "rcbandit", "Car", "null", "Ignore", Properties.Resources.Vehicle_441));
            List_Vehicles.Add(new Class_Vehicle(442, "romero", "Car", "null", "Normal", Properties.Resources.Vehicle_442));
            List_Vehicles.Add(new Class_Vehicle(443, "packer", "Car", "truck", "Worker", Properties.Resources.Vehicle_443));
            List_Vehicles.Add(new Class_Vehicle(444, "monster", "Monster Truck", "truck", "Ignore", Properties.Resources.Vehicle_444));
            List_Vehicles.Add(new Class_Vehicle(445, "admiral", "Car", "null", "Rich Family", Properties.Resources.Vehicle_445));
            List_Vehicles.Add(new Class_Vehicle(446, "squalo", "Boat", "null", "Ignore", Properties.Resources.Vehicle_446));
            List_Vehicles.Add(new Class_Vehicle(447, "seaspar", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_447));
            List_Vehicles.Add(new Class_Vehicle(448, "pizzaboy", "Bike", "bikev", "Normal", Properties.Resources.Vehicle_448));
            List_Vehicles.Add(new Class_Vehicle(449, "tram", "Train", "van", "Ignore", Properties.Resources.Vehicle_449));
            List_Vehicles.Add(new Class_Vehicle(450, "artict2", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_450));
            List_Vehicles.Add(new Class_Vehicle(451, "turismo", "Car", "null", "Executive", Properties.Resources.Vehicle_451));
            List_Vehicles.Add(new Class_Vehicle(452, "speeder", "Boat", "null", "Leisure Boat", Properties.Resources.Vehicle_452));
            List_Vehicles.Add(new Class_Vehicle(453, "reefer", "Boat", "null", "Worker", Properties.Resources.Vehicle_453));
            List_Vehicles.Add(new Class_Vehicle(454, "tropic", "Boat", "null", "Leisure Boat", Properties.Resources.Vehicle_454));
            List_Vehicles.Add(new Class_Vehicle(455, "flatbed", "Car", "truck", "Worker", Properties.Resources.Vehicle_455));
            List_Vehicles.Add(new Class_Vehicle(456, "yankee", "Car", "null", "Worker", Properties.Resources.Vehicle_456));
            List_Vehicles.Add(new Class_Vehicle(457, "caddy", "Car", "null", "Rich Family", Properties.Resources.Vehicle_457));
            List_Vehicles.Add(new Class_Vehicle(458, "solair", "Car", "null", "Normal", Properties.Resources.Vehicle_458));
            List_Vehicles.Add(new Class_Vehicle(459, "topfun", "Car", "van", "Ignore", Properties.Resources.Vehicle_459));
            List_Vehicles.Add(new Class_Vehicle(460, "skimmer", "Plane", "null", "Ignore", Properties.Resources.Vehicle_460));
            List_Vehicles.Add(new Class_Vehicle(461, "pcj600", "Bike", "bikes", "Motorbike", Properties.Resources.Vehicle_461));
            List_Vehicles.Add(new Class_Vehicle(462, "faggio", "Bike", "bikev", "Motorbike", Properties.Resources.Vehicle_462));
            List_Vehicles.Add(new Class_Vehicle(463, "freeway", "Bike", "bikeh", "Motorbike", Properties.Resources.Vehicle_463));
            List_Vehicles.Add(new Class_Vehicle(464, "rcbaron", "Plane", "null", "Ignore", Properties.Resources.Vehicle_464));
            List_Vehicles.Add(new Class_Vehicle(465, "rcraider", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_465));
            List_Vehicles.Add(new Class_Vehicle(466, "glendale", "Car", "null", "Normal", Properties.Resources.Vehicle_466));
            List_Vehicles.Add(new Class_Vehicle(467, "oceanic", "Car", "null", "Normal", Properties.Resources.Vehicle_467));
            List_Vehicles.Add(new Class_Vehicle(468, "sanchez", "Bike", "biked", "Motorbike", Properties.Resources.Vehicle_468));
            List_Vehicles.Add(new Class_Vehicle(469, "sparrow", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_469));
            List_Vehicles.Add(new Class_Vehicle(470, "patriot", "Car", "null", "Ignore", Properties.Resources.Vehicle_470));
            List_Vehicles.Add(new Class_Vehicle(471, "quad", "QUAD", "quad", "Normal", Properties.Resources.Vehicle_471));
            List_Vehicles.Add(new Class_Vehicle(472, "coastg", "Boat", "null", "Ignore", Properties.Resources.Vehicle_472));
            List_Vehicles.Add(new Class_Vehicle(473, "dinghy", "Boat", "null", "Worker", Properties.Resources.Vehicle_473));
            List_Vehicles.Add(new Class_Vehicle(474, "hermes", "Car", "null", "Rich Family", Properties.Resources.Vehicle_474));
            List_Vehicles.Add(new Class_Vehicle(475, "sabre", "Car", "null", "Normal", Properties.Resources.Vehicle_475));
            List_Vehicles.Add(new Class_Vehicle(476, "rustler", "Plane", "rustler", "Ignore", Properties.Resources.Vehicle_476));
            List_Vehicles.Add(new Class_Vehicle(477, "zr350", "Car", "null", "Rich Family", Properties.Resources.Vehicle_477));
            List_Vehicles.Add(new Class_Vehicle(478, "walton", "Car", "null", "Worker", Properties.Resources.Vehicle_478));
            List_Vehicles.Add(new Class_Vehicle(479, "regina", "Car", "null", "Normal", Properties.Resources.Vehicle_479));
            List_Vehicles.Add(new Class_Vehicle(480, "comet", "Car", "null", "Executive", Properties.Resources.Vehicle_480));
            List_Vehicles.Add(new Class_Vehicle(481, "bmx", "BMX", "bmx", "Bicycle", Properties.Resources.Vehicle_481));
            List_Vehicles.Add(new Class_Vehicle(482, "burrito", "Car", "van", "Normal", Properties.Resources.Vehicle_482));
            List_Vehicles.Add(new Class_Vehicle(483, "camper", "Car", "van", "Normal", Properties.Resources.Vehicle_483));
            List_Vehicles.Add(new Class_Vehicle(484, "marquis", "Boat", "null", "Worker", Properties.Resources.Vehicle_484));
            List_Vehicles.Add(new Class_Vehicle(485, "baggage", "Car", "null", "Normal", Properties.Resources.Vehicle_485));
            List_Vehicles.Add(new Class_Vehicle(486, "dozer", "Car", "dozer", "Ignore", Properties.Resources.Vehicle_486));
            List_Vehicles.Add(new Class_Vehicle(487, "maverick", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_487));
            List_Vehicles.Add(new Class_Vehicle(488, "vcnmav", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_488));
            List_Vehicles.Add(new Class_Vehicle(489, "rancher", "Car", "null", "Normal", Properties.Resources.Vehicle_489));
            List_Vehicles.Add(new Class_Vehicle(490, "fbiranch", "Car", "null", "Ignore", Properties.Resources.Vehicle_490));
            List_Vehicles.Add(new Class_Vehicle(491, "virgo", "Car", "null", "Normal", Properties.Resources.Vehicle_491));
            List_Vehicles.Add(new Class_Vehicle(492, "greenwoo", "Car", "null", "Poor Family", Properties.Resources.Vehicle_492));
            List_Vehicles.Add(new Class_Vehicle(493, "jetmax", "Boat", "null", "Ignore", Properties.Resources.Vehicle_493));
            List_Vehicles.Add(new Class_Vehicle(494, "hotring", "Car", "null", "Ignore", Properties.Resources.Vehicle_494));
            List_Vehicles.Add(new Class_Vehicle(495, "sandking", "Car", "null", "Ignore", Properties.Resources.Vehicle_495));
            List_Vehicles.Add(new Class_Vehicle(496, "blistac", "Car", "null", "Normal", Properties.Resources.Vehicle_496));
            List_Vehicles.Add(new Class_Vehicle(497, "polmav", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_497));
            List_Vehicles.Add(new Class_Vehicle(498, "boxville", "Car", "van", "Worker", Properties.Resources.Vehicle_498));
            List_Vehicles.Add(new Class_Vehicle(499, "benson", "Car", "null", "Worker", Properties.Resources.Vehicle_499));
            List_Vehicles.Add(new Class_Vehicle(500, "mesa", "Car", "null", "Normal", Properties.Resources.Vehicle_500));
            List_Vehicles.Add(new Class_Vehicle(501, "rcgoblin", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_501));
            List_Vehicles.Add(new Class_Vehicle(502, "hotrina", "Car", "null", "Ignore", Properties.Resources.Vehicle_502));
            List_Vehicles.Add(new Class_Vehicle(503, "hotrinb", "Car", "null", "Ignore", Properties.Resources.Vehicle_503));
            List_Vehicles.Add(new Class_Vehicle(504, "bloodra", "Car", "BF_injection", "Ignore", Properties.Resources.Vehicle_504));
            List_Vehicles.Add(new Class_Vehicle(505, "rnchlure", "Car", "null", "Normal", Properties.Resources.Vehicle_505));
            List_Vehicles.Add(new Class_Vehicle(506, "supergt", "Car", "null", "Executive", Properties.Resources.Vehicle_506));
            List_Vehicles.Add(new Class_Vehicle(507, "elegant", "Car", "null", "Normal", Properties.Resources.Vehicle_507));
            List_Vehicles.Add(new Class_Vehicle(508, "journey", "Car", "null", "Worker", Properties.Resources.Vehicle_508));
            List_Vehicles.Add(new Class_Vehicle(509, "bike", "BMX", "choppa", "Bicycle", Properties.Resources.Vehicle_509));
            List_Vehicles.Add(new Class_Vehicle(510, "mtbike", "BMX", "mtb", "Bicycle", Properties.Resources.Vehicle_510));
            List_Vehicles.Add(new Class_Vehicle(511, "beagle", "Plane", "van", "Ignore", Properties.Resources.Vehicle_511));
            List_Vehicles.Add(new Class_Vehicle(512, "cropdust", "Plane", "rustler", "Ignore", Properties.Resources.Vehicle_512));
            List_Vehicles.Add(new Class_Vehicle(513, "stunt", "Plane", "rustler", "Ignore", Properties.Resources.Vehicle_513));
            List_Vehicles.Add(new Class_Vehicle(514, "petro", "Car", "truck", "Worker", Properties.Resources.Vehicle_514));
            List_Vehicles.Add(new Class_Vehicle(515, "rdtrain", "Car", "truck", "Worker", Properties.Resources.Vehicle_515));
            List_Vehicles.Add(new Class_Vehicle(516, "nebula", "Car", "null", "Poor Family", Properties.Resources.Vehicle_516));
            List_Vehicles.Add(new Class_Vehicle(517, "majestic", "Car", "null", "Poor Family", Properties.Resources.Vehicle_517));
            List_Vehicles.Add(new Class_Vehicle(518, "buccanee", "Car", "null", "Normal", Properties.Resources.Vehicle_518));
            List_Vehicles.Add(new Class_Vehicle(519, "shamal", "Plane", "shamale", "Ignore", Properties.Resources.Vehicle_519));
            List_Vehicles.Add(new Class_Vehicle(520, "hydra", "Plane", "rustler", "Ignore", Properties.Resources.Vehicle_520));
            List_Vehicles.Add(new Class_Vehicle(521, "fcr900", "Bike", "bikes", "Motorbike", Properties.Resources.Vehicle_521));
            List_Vehicles.Add(new Class_Vehicle(522, "nrg500", "Bike", "bikes", "Motorbike", Properties.Resources.Vehicle_522));
            List_Vehicles.Add(new Class_Vehicle(523, "copbike", "Bike", "bikes", "Ignore", Properties.Resources.Vehicle_523));
            List_Vehicles.Add(new Class_Vehicle(524, "cement", "Car", "null", "Worker", Properties.Resources.Vehicle_524));
            List_Vehicles.Add(new Class_Vehicle(525, "towtruck", "Car", "van", "Worker", Properties.Resources.Vehicle_525));
            List_Vehicles.Add(new Class_Vehicle(526, "fortune", "Car", "null", "Normal", Properties.Resources.Vehicle_526));
            List_Vehicles.Add(new Class_Vehicle(527, "cadrona", "Car", "null", "Poor Family", Properties.Resources.Vehicle_527));
            List_Vehicles.Add(new Class_Vehicle(528, "fbitruck", "Car", "van", "Big", Properties.Resources.Vehicle_528));
            List_Vehicles.Add(new Class_Vehicle(529, "willard", "Car", "null", "Normal", Properties.Resources.Vehicle_529));
            List_Vehicles.Add(new Class_Vehicle(530, "forklift", "Car", "null", "Worker", Properties.Resources.Vehicle_530));
            List_Vehicles.Add(new Class_Vehicle(531, "tractor", "Car", "null", "Normal", Properties.Resources.Vehicle_531));
            List_Vehicles.Add(new Class_Vehicle(532, "combine", "Car", "truck", "Ignore", Properties.Resources.Vehicle_532));
            List_Vehicles.Add(new Class_Vehicle(533, "feltzer", "Car", "null", "Executive", Properties.Resources.Vehicle_533));
            List_Vehicles.Add(new Class_Vehicle(534, "remingtn", "Car", "null", "Executive", Properties.Resources.Vehicle_534));
            List_Vehicles.Add(new Class_Vehicle(535, "slamvan", "Car", "null", "Rich Family", Properties.Resources.Vehicle_535));
            List_Vehicles.Add(new Class_Vehicle(536, "blade", "Car", "null", "Executive", Properties.Resources.Vehicle_536));
            List_Vehicles.Add(new Class_Vehicle(537, "freight", "Train", "truck", "Ignore", Properties.Resources.Vehicle_537));
            List_Vehicles.Add(new Class_Vehicle(538, "streak", "Train", "truck", "Ignore", Properties.Resources.Vehicle_538));
            List_Vehicles.Add(new Class_Vehicle(539, "vortex", "Plane", "vortex", "Ignore", Properties.Resources.Vehicle_539));
            List_Vehicles.Add(new Class_Vehicle(540, "vincent", "Car", "null", "Normal", Properties.Resources.Vehicle_540));
            List_Vehicles.Add(new Class_Vehicle(541, "bullet", "Car", "null", "Executive", Properties.Resources.Vehicle_541));
            List_Vehicles.Add(new Class_Vehicle(542, "clover", "Car", "null", "Poor Family", Properties.Resources.Vehicle_542));
            List_Vehicles.Add(new Class_Vehicle(543, "sadler", "Car", "null", "Normal", Properties.Resources.Vehicle_543));
            List_Vehicles.Add(new Class_Vehicle(544, "firela", "Car", "truck", "Ignore", Properties.Resources.Vehicle_544));
            List_Vehicles.Add(new Class_Vehicle(545, "hustler", "Car", "null", "Normal", Properties.Resources.Vehicle_545));
            List_Vehicles.Add(new Class_Vehicle(546, "intruder", "Car", "null", "Normal", Properties.Resources.Vehicle_546));
            List_Vehicles.Add(new Class_Vehicle(547, "primo", "Car", "null", "Normal", Properties.Resources.Vehicle_547));
            List_Vehicles.Add(new Class_Vehicle(548, "cargobob", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_548));
            List_Vehicles.Add(new Class_Vehicle(549, "tampa", "Car", "null", "Poor Family", Properties.Resources.Vehicle_549));
            List_Vehicles.Add(new Class_Vehicle(550, "sunrise", "Car", "null", "Normal", Properties.Resources.Vehicle_550));
            List_Vehicles.Add(new Class_Vehicle(551, "merit", "Car", "null", "Rich Family", Properties.Resources.Vehicle_551));
            List_Vehicles.Add(new Class_Vehicle(552, "utility", "Car", "van", "Worker", Properties.Resources.Vehicle_552));
            List_Vehicles.Add(new Class_Vehicle(553, "nevada", "Plane", "nevada", "Ignore", Properties.Resources.Vehicle_553));
            List_Vehicles.Add(new Class_Vehicle(554, "yosemite", "Car", "null", "Normal", Properties.Resources.Vehicle_554));
            List_Vehicles.Add(new Class_Vehicle(555, "windsor", "Car", "null", "Executive", Properties.Resources.Vehicle_555));
            List_Vehicles.Add(new Class_Vehicle(556, "monstera", "Monster Truck", "truck", "Ignore", Properties.Resources.Vehicle_556));
            List_Vehicles.Add(new Class_Vehicle(557, "monsterb", "Monster Truck", "truck", "Ignore", Properties.Resources.Vehicle_557));
            List_Vehicles.Add(new Class_Vehicle(558, "uranus", "Car", "null", "Rich Family", Properties.Resources.Vehicle_558));
            List_Vehicles.Add(new Class_Vehicle(559, "jester", "Car", "null", "Rich Family", Properties.Resources.Vehicle_559));
            List_Vehicles.Add(new Class_Vehicle(560, "sultan", "Car", "null", "Rich Family", Properties.Resources.Vehicle_560));
            List_Vehicles.Add(new Class_Vehicle(561, "stratum", "Car", "null", "Rich Family", Properties.Resources.Vehicle_561));
            List_Vehicles.Add(new Class_Vehicle(562, "elegy", "Car", "null", "Rich Family", Properties.Resources.Vehicle_562));
            List_Vehicles.Add(new Class_Vehicle(563, "raindanc", "Helicopter", "null", "Ignore", Properties.Resources.Vehicle_563));
            List_Vehicles.Add(new Class_Vehicle(564, "rctiger", "Car", "null", "Ignore", Properties.Resources.Vehicle_564));
            List_Vehicles.Add(new Class_Vehicle(565, "flash", "Car", "null", "Rich Family", Properties.Resources.Vehicle_565));
            List_Vehicles.Add(new Class_Vehicle(566, "tahoma", "Car", "null", "Rich Family", Properties.Resources.Vehicle_566));
            List_Vehicles.Add(new Class_Vehicle(567, "savanna", "Car", "null", "Poor Family", Properties.Resources.Vehicle_567));
            List_Vehicles.Add(new Class_Vehicle(568, "bandito", "Car", "null", "Ignore", Properties.Resources.Vehicle_568));
            List_Vehicles.Add(new Class_Vehicle(569, "freiflat", "Train", "null", "Ignore", Properties.Resources.Vehicle_569));
            List_Vehicles.Add(new Class_Vehicle(570, "streakc", "Train", "coach", "Ignore", Properties.Resources.Vehicle_570));
            List_Vehicles.Add(new Class_Vehicle(571, "kart", "Car", "KART", "Ignore", Properties.Resources.Vehicle_571));
            List_Vehicles.Add(new Class_Vehicle(572, "mower", "Car", "null", "Ignore", Properties.Resources.Vehicle_572));
            List_Vehicles.Add(new Class_Vehicle(573, "duneride", "Monster Truck", "truck", "Ignore", Properties.Resources.Vehicle_573));
            List_Vehicles.Add(new Class_Vehicle(574, "sweeper", "Car", "null", "Worker", Properties.Resources.Vehicle_574));
            List_Vehicles.Add(new Class_Vehicle(575, "broadway", "Car", "null", "Poor Family", Properties.Resources.Vehicle_575));
            List_Vehicles.Add(new Class_Vehicle(576, "tornado", "Car", "null", "Poor Family", Properties.Resources.Vehicle_576));
            List_Vehicles.Add(new Class_Vehicle(577, "at400", "Plane", "coach", "Ignore", Properties.Resources.Vehicle_577));
            List_Vehicles.Add(new Class_Vehicle(578, "dft30", "Car", "truck", "Worker", Properties.Resources.Vehicle_578));
            List_Vehicles.Add(new Class_Vehicle(579, "huntley", "Car", "null", "Rich Family", Properties.Resources.Vehicle_579));
            List_Vehicles.Add(new Class_Vehicle(580, "stafford", "Car", "null", "Normal", Properties.Resources.Vehicle_580));
            List_Vehicles.Add(new Class_Vehicle(581, "bf400", "Bike", "bikes", "Motorbike", Properties.Resources.Vehicle_581));
            List_Vehicles.Add(new Class_Vehicle(582, "newsvan", "Car", "van", "Normal", Properties.Resources.Vehicle_582));
            List_Vehicles.Add(new Class_Vehicle(583, "tug", "Car", "null", "Normal", Properties.Resources.Vehicle_583));
            List_Vehicles.Add(new Class_Vehicle(584, "petrotr", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_584));
            List_Vehicles.Add(new Class_Vehicle(585, "emperor", "Car", "null", "Normal", Properties.Resources.Vehicle_585));
            List_Vehicles.Add(new Class_Vehicle(586, "wayfarer", "Bike", "wayfarer", "Motorbike", Properties.Resources.Vehicle_586));
            List_Vehicles.Add(new Class_Vehicle(587, "euros", "Car", "null", "Rich Family", Properties.Resources.Vehicle_587));
            List_Vehicles.Add(new Class_Vehicle(588, "hotdog", "Car", "van", "Worker", Properties.Resources.Vehicle_588));
            List_Vehicles.Add(new Class_Vehicle(589, "club", "Car", "null", "Normal", Properties.Resources.Vehicle_589));
            List_Vehicles.Add(new Class_Vehicle(590, "freibox", "Train", "null", "Ignore", Properties.Resources.Vehicle_590));
            List_Vehicles.Add(new Class_Vehicle(591, "artict3", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_591));
            List_Vehicles.Add(new Class_Vehicle(592, "androm", "Plane", "null", "Ignore", Properties.Resources.Vehicle_592));
            List_Vehicles.Add(new Class_Vehicle(593, "dodo", "Plane", "van", "Ignore", Properties.Resources.Vehicle_593));
            List_Vehicles.Add(new Class_Vehicle(594, "rccam", "Car", "null", "Ignore", Properties.Resources.Vehicle_594));
            List_Vehicles.Add(new Class_Vehicle(595, "launch", "Boat", "null", "Leisure Boat", Properties.Resources.Vehicle_595));
            List_Vehicles.Add(new Class_Vehicle(596, "copcarla", "Car", "null", "Ignore", Properties.Resources.Vehicle_596));
            List_Vehicles.Add(new Class_Vehicle(597, "copcarsf", "Car", "null", "Ignore", Properties.Resources.Vehicle_597));
            List_Vehicles.Add(new Class_Vehicle(598, "copcarvg", "Car", "null", "Ignore", Properties.Resources.Vehicle_598));
            List_Vehicles.Add(new Class_Vehicle(599, "copcarru", "Car", "null", "Ignore", Properties.Resources.Vehicle_599));
            List_Vehicles.Add(new Class_Vehicle(600, "picador", "Car", "null", "Normal", Properties.Resources.Vehicle_600));
            List_Vehicles.Add(new Class_Vehicle(601, "swatvan", "Car", "van", "Big", Properties.Resources.Vehicle_601));
            List_Vehicles.Add(new Class_Vehicle(602, "alpha", "Car", "null", "Executive", Properties.Resources.Vehicle_602));
            List_Vehicles.Add(new Class_Vehicle(603, "phoenix", "Car", "null", "Normal", Properties.Resources.Vehicle_603));
            List_Vehicles.Add(new Class_Vehicle(604, "glenshit", "Car", "null", "Normal", Properties.Resources.Vehicle_604));
            List_Vehicles.Add(new Class_Vehicle(605, "sadlshit", "Car", "null", "Normal", Properties.Resources.Vehicle_605));
            List_Vehicles.Add(new Class_Vehicle(606, "bagboxa", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_606));
            List_Vehicles.Add(new Class_Vehicle(607, "bagboxb", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_607));
            List_Vehicles.Add(new Class_Vehicle(608, "tugstair", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_608));
            List_Vehicles.Add(new Class_Vehicle(609, "boxburg", "Car", "van", "Worker", Properties.Resources.Vehicle_609));
            List_Vehicles.Add(new Class_Vehicle(610, "farmtr1", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_610));
            List_Vehicles.Add(new Class_Vehicle(611, "utiltr1", "Tailer", "null", "Ignore", Properties.Resources.Vehicle_611));

            Temp_VL = List_Vehicles.ToList();

            ComboBox_FilterByType.Items.Add("All");
            ComboBox_FilterByClass.Items.Add("All");
            ComboBox_FilterByAnimation.Items.Add("All");

            foreach (Class_Vehicle Vehicle in Temp_VL)
            {
                ListBox_List.Items.Add(Vehicle.Model_name);

                if(!ComboBox_FilterByType.Items.Contains(Vehicle.Model_type))
                    ComboBox_FilterByType.Items.Add(Vehicle.Model_type);

                if(!ComboBox_FilterByClass.Items.Contains(Vehicle.Model_class))
                    ComboBox_FilterByClass.Items.Add(Vehicle.Model_class);

                if(!ComboBox_FilterByAnimation.Items.Contains(Vehicle.Model_animation))
                    ComboBox_FilterByAnimation.Items.Add(Vehicle.Model_animation);
            }

            ComboBox_FilterByType.SelectedIndex = 0;
            ComboBox_FilterByClass.SelectedIndex = 0;
            ComboBox_FilterByAnimation.SelectedIndex = 0;

            NumericUpDown_SearchByID.Maximum = Temp_VL.Count;
            NumericUpDown_SearchByModelID.Maximum = Temp_VL[Temp_VL.Count - 1].Model_id;

            UpdatePreview(_index);
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            if(_index > 0)
                UpdatePreview(--_index);

            else
            {
                StatusStrip_Stats.Items.Clear();
                StatusStrip_Stats.Items.Add("Notice: You've already reached the first entity!");
                StatusStrip_Stats.BackColor = Color.Red;
                Label_Version.BackColor = Color.Red;
            }
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            if(_index < Temp_VL.Count - 1)
                UpdatePreview(++_index);
            else
            {
                StatusStrip_Stats.Items.Clear();
                StatusStrip_Stats.Items.Add("Notice: You've already reached the last entity!");
                StatusStrip_Stats.BackColor = Color.Red;
                Label_Version.BackColor = Color.Red;
            }
        }

        private void Button_First_Click(object sender, EventArgs e)
        {
            UpdatePreview(_index = 0);
        }

        private void Button_Last_Click(object sender, EventArgs e)
        {
            UpdatePreview(_index = Temp_VL.Count - 1);
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Eoussama\nCreation date: 10/02/2017\nVersion: 0.1\nBig thanks to the SA-MP team", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A simple programme with useful vehicle information for SA-MP developement.\n\nThe programme provides total control over the presentation of different information conserning vehicles.", "Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListBox_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePreview(_index = ListBox_List.SelectedIndex);
        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            ListBox_List.Items.Clear();

            Temp_VL = List_Vehicles.ToList();
           
            foreach (Class_Vehicle Vehicle in Temp_VL)
                ListBox_List.Items.Add(Vehicle.Model_name);

            ComboBox_FilterByType.SelectedIndex = 0;
            ComboBox_FilterByClass.SelectedIndex = 0;
            ComboBox_FilterByAnimation.SelectedIndex = 0;

            NumericUpDown_SearchByID.Maximum = Temp_VL.Count;
            NumericUpDown_SearchByID.Minimum = 1;
            NumericUpDown_SearchByModelID.Maximum = 611;
            NumericUpDown_SearchByModelID.Value = 400;
            NumericUpDown_SearchByID.Value = 1;

            TextBox_SearchByName.Clear();

            RadioButton_SearchByModelID.Checked = false;
            RadioButton_SearchByID.Checked = false;
            RadioButton_SearchByName.Checked = false;

            NumericUpDown_SearchByModelID.Enabled = false;
            NumericUpDown_SearchByID.Enabled = false;
            TextBox_SearchByName.Enabled = false;

            Button_Search.Enabled = false;

            UpdatePreview(_index = 0);
        }

        private void RadioButton_SearchByModelID_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown_SearchByModelID.Enabled = true;
            NumericUpDown_SearchByID.Enabled = false;
            TextBox_SearchByName.Enabled = false;

            Button_Search.Enabled = true;
        }

        private void RadioButton_SearchByID_CheckedChanged(object sender, EventArgs e)
        {
            NumericUpDown_SearchByID.Enabled = true;
            NumericUpDown_SearchByModelID.Enabled = false;
            TextBox_SearchByName.Enabled = false;

            Button_Search.Enabled = true;
        }

        private void RadioButton_SearchByName_CheckedChanged(object sender, EventArgs e)
        {
            TextBox_SearchByName.Enabled = true;
            NumericUpDown_SearchByModelID.Enabled = false;
            NumericUpDown_SearchByID.Enabled = false;

            Button_Search.Enabled = true;
        }

        private void Button_Random_Click(object sender, EventArgs e)
        {
            Random _rand = new Random();
            int rand_index = _rand.Next(0, Temp_VL.Count);

            UpdatePreview(_index = rand_index);
        }

        private void Button_Copy_Click(object sender, EventArgs e)
        {
            Form_Copy Form = new Form_Copy();
            Form.ShowDialog();
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            if(RadioButton_SearchByModelID.Checked == true)
            {
                int veh_id = 0;

                foreach (Class_Vehicle Vehicle in Temp_VL)
                {
                    if ((int)NumericUpDown_SearchByModelID.Value != Vehicle.Model_id)
                        veh_id++;

                    else
                        break;
                }

                if(veh_id == Temp_VL.Count)
                    MessageBox.Show("There is no matching model ID on the list", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                else
                    UpdatePreview(_index = veh_id);
            }

            else if(RadioButton_SearchByID.Checked == true)
            {
                UpdatePreview(_index = (int)NumericUpDown_SearchByID.Value - 1);
            }

            else
            {
                if (TextBox_SearchByName.Text.Length == 0)
                    MessageBox.Show("Input a valid model name first", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                else
                {
                    int veh_id = 0;

                    foreach (Class_Vehicle Vehicle in Temp_VL)
                    {
                        if (!Vehicle.Model_name.Equals(TextBox_SearchByName.Text.ToLower()))
                            veh_id++;

                        else
                            break;
                    }

                    if (veh_id == Temp_VL.Count)
                        MessageBox.Show("There is no matching model name on the list", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    else
                        UpdatePreview(_index = veh_id);
                }
            }
        }

        private void Button_Filter_Click(object sender, EventArgs e)
        {
            List<Class_Vehicle> _sub_list = new List<Class_Vehicle>();

            if (ComboBox_FilterByType.SelectedIndex != 0)
            {
                foreach (Class_Vehicle Vehicle in List_Vehicles)
                {
                    if (Vehicle.Model_type.Equals(ComboBox_FilterByType.Items[ComboBox_FilterByType.SelectedIndex].ToString()))
                        _sub_list.Add(Vehicle);
                }
            }

            else
                _sub_list = List_Vehicles.ToList();

            if (ComboBox_FilterByClass.SelectedIndex != 0)
            {
                foreach (Class_Vehicle Vehicle in _sub_list.ToList())
                {
                    if (!Vehicle.Model_class.Equals(ComboBox_FilterByClass.Items[ComboBox_FilterByClass.SelectedIndex].ToString()))
                        _sub_list.Remove(Vehicle);
                }
            }
            
            if (ComboBox_FilterByAnimation.SelectedIndex != 0)
            {
                foreach (Class_Vehicle Vehicle in _sub_list.ToList())
                {
                    if (!Vehicle.Model_animation.Equals(ComboBox_FilterByAnimation.Items[ComboBox_FilterByAnimation.SelectedIndex].ToString()))
                        _sub_list.Remove(Vehicle);
                }
            }

            if (_sub_list.Count == 0)
                MessageBox.Show("There are no vehicles matching that filter", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            else
            {
                ListBox_List.Items.Clear();

                Temp_VL = _sub_list;
                
                foreach(Class_Vehicle Vehicle in Temp_VL)
                    ListBox_List.Items.Add(Vehicle.Model_name);

                UpdatePreview(_index = 0);
            }
        }

        private void Button_Export_Click(object sender, EventArgs e)
        {
            DialogResult Rep = SaveFileDialog_Export.ShowDialog();
            string path = SaveFileDialog_Export.FileName, _content;

            if (Rep == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(path + ".pwn", true);
                int _iterator = 0;

                _content = "Array_Vehicles[" + Form_Main.Temp_VL.Count + "] = {\n";

                foreach (Class_Vehicle Vehicle in Form_Main.Temp_VL)
                    _content += Vehicle.Model_id.ToString() + ((++_iterator == Form_Main.Temp_VL.Count) ? "\n" : ",\n");

                _content += "};";
                SW.WriteLine(_content);
                SW.Close();

                MessageBox.Show("You have successfully saved the vehicle array under “" + path + ".pwn”", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void UpdatePreview(int _index)
        {
            Class_Vehicle Vehicle = Temp_VL[_index];

            PictureBox_Preview.Image = Vehicle.Model_image;
            Label_VehicleName.Text = Vehicle.Model_name;
            Label_VehicleModelID.Text = Vehicle.Model_id.ToString();
            Label_VehicleType.Text = Vehicle.Model_type;
            Label_VehicleClass.Text = Vehicle.Model_class;
            Label_VehicleAnimation.Text = Vehicle.Model_animation;

            StatusStrip_Stats.Items.Clear();
            StatusStrip_Stats.Items.Add("Selected Entity N°: " + (_index + 1) + "    |    Total Entities: " + Temp_VL.Count);
            StatusStrip_Stats.BackColor = Color.Transparent;
            Label_Version.BackColor = Color.Transparent;

            ListBox_List.SelectedIndex = _index;
        }

        private void Button_Import_Click(object sender, EventArgs e)
        {
            DialogResult Rep = OpenFileDialog_Import.ShowDialog();

            if (Rep == DialogResult.OK)
            {
                string path = OpenFileDialog_Import.FileName, line;
                int modelid = 0;
                FileStream FS = new FileStream(path, FileMode.Open);
                StreamReader SR = new StreamReader(FS);

                Temp_VL.Clear();
                while ((line = SR.ReadLine()) != null)
                {
                    line = line.Remove(line.Length - 1);

                    if(int.TryParse(line, out modelid))
                    {
                        if (611 >= modelid && modelid >= 400)
                        {
                            foreach (Class_Vehicle Vehicle in List_Vehicles.ToList())
                            {
                                if (Vehicle.Model_id == modelid)
                                    Temp_VL.Add(Vehicle);
                            }
                        }
                    }
                }

                SR.Close();
                FS.Close();

                if(Temp_VL.Count > 0)
                {
                    ListBox_List.Items.Clear();

                    foreach (Class_Vehicle Vehicle in Temp_VL)
                        ListBox_List.Items.Add(Vehicle.Model_name);

                    UpdatePreview(_index = 0);
                }
            }
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("> Importing an array\nBefore you import an array, make sure it follows the same formula the exported files support, ignoring that will cause the application to crash!", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}