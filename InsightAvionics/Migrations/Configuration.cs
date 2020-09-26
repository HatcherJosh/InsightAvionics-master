namespace InsightAvionics.Migrations
{
    using InsightAvionics.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InsightAvionics.Models.InsightAvionicsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InsightAvionics.Models.InsightAvionicsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //var product = new Product {ProdName="G1 Engine Monitor", ProdImage =@"~\Assets\ProductImages\g1.png",ProdDesc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed bibendum molestie semper. Pellentesque hendrerit odio nisi. Maecenas interdum volutpat tempus. Donec congue ante nec libero tempor, a tincidunt quam pretium. Donec orci eros, mattis non eros id, pretium porttitor purus. Duis eget tortor at risus maximus luctus vel accumsan lorem. Nunc mattis volutpat lectus, elementum egestas augue congue at. Nulla a scelerisque ipsum.Nunc sed urna nisl.Curabitur porttitor gravida velit, ac aliquet felis dictum sit amet.Sed vel tincidunt tortor.Proin condimentum interdum velit, ac rhoncus tellus blandit eu.Ut aliquam mi eu magna lobortis volutpat.Sed in posuere quam.Vestibulum pulvinar orci eu dapibus convallis.Etiam eget ligula nibh.Curabitur maximus mattis sem non tincidunt.Mauris a dignissim mi, et ultricies orci.Donec mollis semper sem, sed porttitor sapien accumsan id.Proin quis convallis ante.Morbi quis condimentum sem.Fusce consectetur volutpat ipsum sit amet fringilla.Suspendisse nunc elit, mollis non pretium non, nterdum sed libero.Phasellus vel consequat lectus. Integer sit amet dignissim dui.Cras varius nunc in lacus fringilla hendrerit.Nullam ultrices lorem et diam porttitor,  non dignissim justo mollis.Mauris enim nisi, imperdiet vel aliquet quis, elementum vitae est.Sed ut scelerisque ante, sit amet sodales tellus.Suspendisse nec orci non risus ullamcorper posuere quis a erat.Sed ac nisi felis.Phasellus nec mauris eget augue fermentum venenatis.Nulla eu ante id lectus tincidunt convallis.Phasellus eu cursus velit, in mollis nibh.Ut eget commodo nulla.Ut ut ex non odio porta pulvinar non eu orci.Integer sed rhoncus augue.Vivamus gravida auctor arcu,get facilisis ante hendrerit in. Fusce sollicitudin massa vel elit pharetra,ut hendrerit metus condimentum.Sed in facilisis ligula. "};
            //context.Products.Add(product);
            //context.SaveChanges();

            var p = "";

            context.Products.AddOrUpdate(x => x.ProdID,
                   new Product() { ProdName = "G1 Engine Monitor", ProdShort = "G1", ProdDesc = @"•Low Altitude VFR•4 Cylinder•Carbureted•Running ROP", ProdBody = @"<div class='center'><img height='320' src='Site/images/G1%20FACE.jpg' width='576'></div> <br>
				<div><h3><strong>Notice – If you have an injected fuel system and are planning on running or running lean of peak: 
<span style='color:red'>G2, 3</span> or <span style='color:red'>4</span> is a better choice. </strong> </h3>
							<p>
							The G1 GEM offers the basic monitoring features for EGT/CHT and CT (Carburetor Temperature) as the other G-series GEMs but not the advanced leaning features (that require real-time fuel flow data).<br>
 
All EGT/CHT/CT data is continuously displayed in colour-coded bar-graph and numeric form, but neither mixture lean-of-peak (LOP) nor rich-of-peak (ROP) indication is provided. Leaning boxes do appear following peak-EGT events but the delta temperature number inside each leaning-box only shows the magnitude of temperature drop.<br>
 
The LOP or ROP mixture status must be determined by the pilot by knowledge of which direction the mixture control was moved following a peak-EGT event. Moving the mixture control to increase fuel flow after finding peak EGT will result in a ROP condition, and moving the mixture to reduce fuel flow after finding peak EGT will result in a LOP condition. <br>

Users of the G1 GEM should disregard references to GEM fuel flow indications in this manual. Similarly any feature that requires use of the rotary control knobs or user configuration screens is not available on the G1 GEM and should be disregarded.
							</p></div>
							<div class='center'>
				<img alt='G1' height='330' src='Site/images/fullg1.png' style='box-sizing: border-box; border: 0px; vertical-align: middle;' width='331'></div>
				<div>
								<p>
								<h3 class='center'>The G1 is the first low cost complete color graphic engine monitor system available in aviation today.</h3>
							G2, 3 or 4&nbsp;may be a better choice because you get:<br>
<ul><li>Superior Patented Leaning Process:</li>
<ul><li>G2/3/4 makes the lean process easy.</li>
<li>No one else has this unique leaning process.</li>
<li>G2/3/4 leaning is so easy and complete we patented the 
process - <a href='pdf%20files/G3%20Manuals/G%20Series/G%20Series%20Patent.pdf'>Read Patent</a></li></ul>
<li>With patented features like:</li>
<ul><li>Pilot settable lean threshold target.</li>
<li>Colored box appears at peak.</li>
<li>Lean boxes show temperature of how much lean or richColored boxes show lean or rich.</li>
<li>Lean boxes change at lean threshold.</li>
<li>Fuel flow guidance for leaningFuel flow at each cylinder peak (GAMI SPREAD)In-flight exhaust valve analysis.</li>
<li>EGT temperature bars with numbers.</li>
<li>CHT temperature bars with number, yellow warning and redline.</li>
<li>TIT temperature bar with number, yellow warning and redline.</li>
</ul></ul></p></div>				

<p class='style173' style='box-sizing: border-box; margin: 0px; text-align: center; font-weight: bold;'>
								<img alt='G1 Kit' class='style174' height='159' src='Site/images/g1kit.gif' style='box-sizing: border-box; border: 1px solid; vertical-align: middle;' width='360'></p>
								
								<span class='style137' style='box-sizing: border-box; font-family: Arial, Helvetica, sans-serif; border-collapse: separate; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px;'>
								<p class='style175' style='box-sizing: border-box; margin: 0px; text-align: center; font-size: small;'>
								Example of what's in a G1 4 cylinder kit.</p>
								</span>
				<hr style='box-sizing: content-box; height: 2px; margin-top: 25px; margin-bottom: 0px; border-width: 1px 0px; border-bottom-style: solid; border-bottom-color: rgb(250, 250, 250); border-top-style: solid; border-top-color: rgb(217, 217, 217);'>
				<h3 class='center'>Built In G1 Probe Diagnosis Screen</h3>
								<div class='center'><img alt='G1' height='190' src='Site/images/g1probe.png' style='vertical-align: middle; margin: 10px;' width='190'></div>
								<div>
									<h4>Revolutionary New G1 Leaning Process</h4>
								<ul>
									<li>Unparalleled ease of operation</li>
								<li>As cylinders peak, boxes will appear on top of EGTs showing peak order and temperature spread.</li>
								<li>Restarting The Leaning Process</li>
									<li>Restart the leaning process and resetting the peak indications on G1 by short push of bottom button.</li>
									<li>Built In G1 Probe Diagnosis Screen Continuous probe diagnostic</li>
									<li>Confirm system integrity</li>
									<li>Troubleshoot engine or a probe problem instantly</li>
									</ul>
</p></div>

				<div class='style142' style='box-sizing: border-box; text-align: center;'>
					<span class='style144' style='box-sizing: border-box; font-size: xx-large; border-collapse: separate; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px;'>
					<br style='box-sizing: border-box;'>
					<img class='responsive' alt='Functions' src='New%20Images/function%20chart.jpg' width='830';></span></div>
				<o:p style='box-sizing: border-box;'>
				<div class='center'>
					<br><a href='#top'>
					<img alt='Top' height='40' src='Site/icons/back-top.png' width='100'></a></div>
				<p>&nbsp;</p>
				<!--/body content --></div>" },
                   new Product() { ProdName = "G2 Engine Monitor", ProdShort="G2", ProdDesc = "•VFR - IFR•4 Or 6 Cylinder•Carb Or Injected•Running ROP", ProdBody = @"
				<div class='center'><img alt='G2' height='437' src='Site/images/G2%20FACE.jpg' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='576' class='auto-style17'></div> <br>
				<h3>Save fuel, save your engine!</h3>
				<br>
				Superior Patented Leaning Process:<ul>
					<li>
					G2/3/4 makes the lean process easy</li>
					<li>
					No one else has this unique leaning process</li>
					<li>
					G2/3/4 leaning is so easy and complete we patented the process<span class='Apple-converted-space' style='box-sizing: border-box;'><strong>&nbsp;</strong></span><span class='auto-style7'><strong>-</strong></span><span><strong>&nbsp;</strong></span><a href='pdf%20files/G3%20Manuals/G%20Series/G%20Series%20Patent.pdf' style='box-sizing: border-box; color: rgb(220, 53, 34); text-decoration: none;' target='_blank'><strong>Read Patent</strong></a></li>
				</ul>
				<p>
				With patented features like:</p>
				<ul>
					<li>Pilot settable lean threshold target</li>
					<li>Colored box appears at peak</li>
					<li>Lean boxes show temperature of how much lean or rich</li>
					<li>Colored boxes show lean or rich</li>
					<li>Lean boxes change at lean threshold</li>
					<li>Fuel flow guidance for leaning</li>
					<li>Fuel flow at each cylinder peak (GAMI SPREAD)</li>
					<li>EGT temperature bars with numbers</li>
					<li>CHT temperature bars with number, yellow warning and redline</li>
					<li>TIT temperature bar with number, yellow warning and redline</li>
				</ul>
				<div class='center'>
				<img alt='G2' height='330' src='Site/images/fullg2.png' style='box-sizing: border-box; border: 0px; vertical-align: middle;' width='331'></div>
				<h4>Controlling the G2 instrument</h4>
				<p>
The instrument has two control knobs that operate combination rotary and push button switches. The top knob in general controls screen selection while the bottom knob controls items within the given screen. Each screen assigns its own functional needs to the controls that may change depending on context. A screen may also label the controls with guidance information like “Push to exit”.<br>
 <br>
<h4>The Bar-Graph Display Screen</h4>
The Exhaust Gas Temperature is displayed in white bar graph form and is interpreted much like a conventional mercury thermometer. The higher the bar, the higher the temperature.<br>
<br>
The cylinder head temperature is displayed in green single bar format. During normal operation it shows as a green illuminated bar in the lower half of the bar column. Since EGT is normally higher than CHT, the green bar which represents CHT is on top of the white illuminated EGT bar and stands out clearly. However, when the engine is shutdown, the EGT quickly drops to zero and the cylinders remain warm for sometime.<br>
<br>
The G2 provides a reliable indication of cylinder head temperature even with the engine shut down. Should an EGT probe fail, the entire EGT column for that cylinder will go blank, and the numeric indication will show --- that is dashes, but the CHT bar will still remain green. The failure of one probe will not affect the display of any other probe.<br>
<br>
<h4>An Easy Upgrade</h4> 
A key requirement of the G2 design was compatibility with previous GEM’s. We strive to never leave our loyal customers behind. Packing all the functionality of the G2 in package half the size of the original GEM took us to the limit of our patience many times but it was worth it. Fortunately its amazingly compact circuits will be built by robotic machines because most of the parts are too small to handle and too difficult to be seen by eye. Products like the modern cell phone have driven the electronic assembly technology we use a long way.
				</p>
				<p>AVWeb Insider -&nbsp;<a href='http://www.avweb.com/blogs/insider/KitplanesBlog_SunNFun2008_InsightEngineMonitor_197596-1.html' style='box-sizing: border-box; color: rgb(51, 51, 51); text-decoration: underline;'>New 
							Insight Engine Monitor and So Much More</a> <em style='box-sizing: border-box;'>By Rick 
							Lindstrom</em> </p>
				<h1 style='box-sizing: border-box; font-size: 16px; margin: 0px 0px -12px; font-family: Arial, Helvetica, sans-serif; font-weight: bold; line-height: 16px; letter-spacing: -1px; color: rgb(0, 0, 0); padding: 0px; text-shadow: rgba(0, 0, 0, 0.0980392) 1px 1px 1px; text-align: left; font-style: normal;'>
				<font color='black' style='box-sizing: border-box;'>
				<br style='box-sizing: border-box;'></font></h1>
				<p>Insight, the originator of the Graphic Engine Monitor, 
							surprised everyone by unveiling a new third 
							generation GEM called<b style='box-sizing: border-box; font-weight: bold;'><span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;</span>G2</b><span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;</span>at 
							Sun n Fun. By no means a lukewarm sequel, the<span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;</span><b style='box-sizing: border-box; font-weight: bold;'>G2</b><span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;</span>is 
							a breakthrough product.<br>
							Featuring a bright full color display it offers 
							numerous screens of new functionality previously 
							unavailable anywhere.<br>
							While the original lean screen is gone, a vastly improved screen replaces it with special functionality for lean of peak operation.
							G2 logs data to readily available SD digital camera cards. A low cost card will store decades of flight data.<br>
The new G2 writes PC compatible files and directories so no special software is required to process or transfer data.<br>
Despite its enormous capabilities the new G2 is a compact size and plug-compatible replacement for all 610 GEMs.<br>
Insight offers a generous GEM trade-in to make upgrades easy.<br>
</p>
				<hr style='box-sizing: content-box; height: 2px; margin-top: 25px; margin-bottom: 0px; border-width: 1px 0px; border-bottom-style: solid; border-bottom-color: rgb(250, 250, 250); border-top-style: solid; border-top-color: rgb(217, 217, 217);'>
				<p><strong>Aircraft&nbsp;install weight<span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;</span>-</strong>&nbsp;A G3 for 6 cylinder with 8 foot 								harness, all sensors, wiring, connectors and probes is 4.2lbs.</p>
				
				<p class='style143' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G2' height='189' src='Site/images/g2-1.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'><span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;</span><img alt='G2T' height='189' src='Site/images/g2.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'></p>
				<p class='style143' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G' height='308' src='Site/images/2.25.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='317'></p>
				<div class='style142' style='box-sizing: border-box; text-align: center;'>
					<span class='style144' style='box-sizing: border-box; font-size: xx-large; border-collapse: separate; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px;'>
					<img alt='G Size' height='296' src='Site/images/g123size.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='600'><br style='box-sizing: border-box;'>
					<img class='responsive' alt='Functions' src='New%20Images/function%20chart.jpg' width='830';></span></div>
				<hr style='box-sizing: content-box; height: 2px; margin-top: 25px; margin-bottom: 0px; border-width: 1px 0px; border-bottom-style: solid; border-bottom-color: rgb(250, 250, 250); border-top-style: solid; border-top-color: rgb(217, 217, 217);'><h3>TOP REASONS TO INSTALL A G2</h3>
				<br style='box-sizing: border-box;'>
				<ol>
				<li> Best lean of peak process in the industry.</li>
				<li> The only nozzle balance analysis, the key to lean of peak.	</li>			
				<li> The only probe diagnostic screen</li>
				<li> Comprehensive	data log windows files SD card</li>
				<li> Over the web software updates means constant improvement</li>
				<li> GEM plug compatible easy install</li>
				<li> Best technical support</li>
									</ol>
									<hr style='box-sizing: content-box; height: 2px; margin-top: 25px; margin-bottom: 0px; border-width: 1px 0px; border-bottom-style: solid; border-bottom-color: rgb(250, 250, 250); border-top-style: solid; border-top-color: rgb(217, 217, 217);'>
								<h3>G2 Buss Voltage</h3>
								<p>The G2 Buss Voltage attempts to display the buss 
								voltage in green when it’s normal and red when 
								it’s outside of normal. In an aircraft with a 
								12V electrical system the Buss Voltage will be 
								annunciated in green so long as the voltage is 
								12.0V to 14.9V (inclusive). In an aircraft with a 24V electrical system the 
								Buss Voltage will be annunciated in green so 
								long as the voltage is 24.2V to 28.7V 
								(inclusive). Below this range the alternator 
								isn’t charging the battery and above that it’s 
								overcharging, and the Buss Voltage will be 
								annunciated in red. The instrument must be connected to the main 
								voltage buss (not in series with something else, 
								on a lighting buss, etc.) and must have a good 
								low-resistance ground connection, otherwise the 
								voltage measurement itself will be in error 
								causing the Buss Voltage to indicate in red 
								erroneously.</p>
				<hr style='box-sizing: content-box; height: 2px; margin-top: 25px; margin-bottom: 0px; border-width: 1px 0px; border-bottom-style: solid; border-bottom-color: rgb(250, 250, 250); border-top-style: solid; border-top-color: rgb(217, 217, 217);'>
								<h3>Pages you will see on your new G2</h3>
								<p class='style150' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: medium; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G2' height='189' src='Site/images/g2-1.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'></p>
				<p class='style151' style='box-sizing: border-box; margin: 0px; padding: 5px; font-size: small; font-family: Arial, Helvetica, sans-serif; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>Monitor Page</p>
				<p class='style150' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: medium; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G2 Probe' height='189' src='Site/images/g2probe.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'></p>
				<p class='style151' style='box-sizing: border-box; margin: 0px; padding: 5px; font-size: small; font-family: Arial, Helvetica, sans-serif; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>Probe Analysis Page</p>
				<p class='style150' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: medium; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G2 Fuel' height='189' src='Site/images/g2fuel.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'></p>
				<p class='style151' style='box-sizing: border-box; margin: 0px; padding: 5px; font-size: small; font-family: Arial, Helvetica, sans-serif; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>Fuel Page</p>
				<p class='style150' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: medium; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<span class='style132' style='box-sizing: border-box; font-size: small;'>Lean of peak</span><img alt='G2 LOP' height='189' src='Site/images/g2lop.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'><img alt='G2 ROP' height='189' src='Site/images/g2rop.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'><span class='style132' style='box-sizing: border-box; font-size: small;'>Rich 
								of peak</span></p>
				<p class='style150' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: medium; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p class='style151' style='box-sizing: border-box; margin: 0px; padding: 5px; font-size: small; font-family: Arial, Helvetica, sans-serif; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<h3 style='color: red;'><b>NEW!</b> Fuel Screens</h3>
				<p>Previously, there was no standard color scheme in 
					the configuration screens. 
					<br>Now the selected line is yellow and the inactive lines are white. 
					<br>YES/NO 
					in red has been removed by displaying only the word YES or 
					the word NO in green, when saving. 
					<br>When there is a choice of several items the selected item is displayed in green. 
					<br>Exactly one item is always selected. <br>The 
					choices of temperature units are Celsius or Fahrenheit then 
					either Fahrenheit or Celsius will be selected in green.
				<strong>
					<br>The FUEL TOTALIZATION screen has been improved and is 
					even easier to use. </strong><br>This change allows the 
					pilot to see this screen before entering fuel on board. <br>Also setting initial fuel can be checked and corrected in 
					flight. <br>Previously the pilot had to enter the amount of 
					fuel onboard before he could view the <strong>FUEL TOTALIZATION</strong> 
					page. <br>Now both the <strong>FUEL TOTALIZATION</strong> page and the 
						<strong>FUEL 
					SETUP</strong> page are accessible at any time. <br>On the 
						<strong>FUEL 
					TOTALIZATION</strong> screen simply press the PG (left) button to 
					enter fuel, press it again when done. <br>As before you can 
					top up the tank(s) by turning the SEL (right) knob counter 
					clockwise on the very first click.<di>					
					Set total fuel onboard before take-off<br>Your G2-3-4 was preset at factory with your usable 
					total fuel &nbsp; <br>To reach <strong>FUEL TOTALIZATION</strong> screen from the main 
					screen. &nbsp; <br>Turn the PG knob counterclockwise one click. &nbsp;
							<br>Push PG knob to go back and forth between the 
							<strong>FUEL 
					SETUP</strong> and <strong>FUEL TOTALIZATION</strong> screens &nbsp;
							<br>On FUEL SETUP screen setting fuel gallons the lines 
					&nbsp;FUEL ADDED, SUBTOTAL and FUEL NOW color will be yellow. &nbsp;
							<br>Turn SEL knob to set gallons (Clockwise or 
					Counterclockwise one click for total preset total fuel for 
					your aircraft) <br>At any time you can push PG knob to go back and forth 
					between the <strong>FUEL SETUP</strong> and <strong>FUEL TOTALIZATION</strong> screens to add 
					more fuel.
					</p>
				<p class='style131' style='box-sizing: border-box; margin: 0px; padding: 5px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='Fuel' height='190' src='Site/images/g2fuel1.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='190'>&nbsp;&nbsp;<span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;<span class='style144' style='font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-size: xx-large; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none;'><span class='style144' style='box-sizing: border-box; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-size: xx-large; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none; background-color: rgb(255, 255, 255);'><span style='box-sizing: border-box; border-collapse: separate; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px;'><img alt='G2 Fuel' height='189' src='Site/images/g2fuel.png' style='box-sizing: border-box; border: 0px; vertical-align: middle; max-width: 100%;' width='189'></span></span></span></span>&nbsp;<span class='Apple-converted-space' style='box-sizing: border-box;'>&nbsp;</span></p>
				<p style='box-sizing: border-box; margin: 0px; padding: 5px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p class='MsoNormal' style='box-sizing: border-box; margin: 0px; padding: 5px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<h3>GEM FUEL TOTALIZER CAUTIONARY NOTICE</h3>
				<o:p style='box-sizing: border-box;'></o:p>The Fuel Remaining display on the GEM is very 
								useful, but it is not without limitations. 
								Understand first that the factory fuel quantity 
								gauges are the only instruments in the panel 
								that physically measure fuel level. They are 
								still the primary indication of fuel level in 
								the airplane.<o:p style='box-sizing: border-box;'></o:p>The GEM doesn’t measure level, but instead 
								measures only fuel flow rate. The GEM totalizes 
								the rate information to account for fuel used. 
								If you know how much fuel you started with and 
								how much you have used you can figure fuel 
								remaining by simple subtraction.The pilot must supply an accurate starting fuel 
								level for this subtraction to produce the 
								correct fuel remaining result. Should the pilot 
								overstate the fuel quantity on board, the GEM 
								will dangerously overstate the fuel remaining 
								and the endurance time as well. The pilot must 
								be careful and diligent when setting the fuel on 
								board. Getting the correct fuel total on board is, in 
								many cases, quite simple. If you fill up prior to 
								takeoff the number is the total 
								available on board. If you partially fill a 
								known configuration (say, tips empty) then the 
								total is easy to calculate. If you partially 
								fill fuel tanks or add an accurately know 
								quantity to a poorly known original value - 
								errors will abound. Unaccounted fuel loss from 
								leakage, fuel vent overflow or theft will of 
								course produce erroneous results. So be careful 
								and the GEM will deliver safe, reliable, and 
								convenient fuel information. But be sure to 
								cross reference the information on the primary 
								fuel quantity gauges. Never trust a single 
								source of fuel information when you have two on 
								board. Fuel exhaustion still ranks highly among 
								accident causes. Don’t let your engine stop 
								until you’re parked.<span class='style132' style='box-sizing: border-box; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-size: small; color: rgb(0, 0, 0); line-height: normal; border-collapse: separate; font-family: 'Times New Roman'; orphans: 2; widows: 2; border-spacing: 0px; -webkit-text-decorations-in-effect: none; background-color: rgb(255, 255, 255);'><p class='text-center' style='box-sizing: border-box; margin: 0px; text-align: center;'>
				&nbsp;</p>
				</span>
				<div class='center'>
					<br><a href='#top'>
					<img alt='Top' height='40' src='Site/icons/back-top.png' width='100'></a></div>
				<p>&nbsp;</p>
				<!--/body content --></div>" 
                   },
                   new Product() { ProdName = "G3 Engine Monitor", ProdShort = "G3", ProdDesc = "•VFR - IFR•4 Or 6 Cylinder•Injected & Turbo•Running Serious LOP•Exhaust Valve Analysis ", ProdBody = @"
				<h2 class='center'><strong>Here's why you should install <span class='red-text'>G3 </span><span class='black-text'>or</span><span class='red-text'> G4</span>:</strong></h2>
				<div>
				<h2>Leaning:</h2>
							<p>G Series is 
							the 
							best technology available, there’s nothing else like 
							it, nothing even comes close to the advantages 
				provided by the G Series. Operation lean of peak requires special information 
							that only the G3 or G4 Graphic Engine Monitor can 
							provide. The G Series instruments are extraordinarily capable 
							yet easy to use. G Series specialized 
				innovative leaning process is the first and only one to ever 
				earn a patent,
				<a href='pdf%20files/G3%20Manuals/G%20Series/G%20Series%20Patent.pdf'>which may be read here.</a>
				<br>The G series is unprecedented in its sophistication, and it makes a complex process easy to 
							accomplish. Leaning with reference to temperature only is just 
							too confusing for LOP. Our specialized process reports each individual 
							cylinders status in unambiguous form. You needn’t ponder if a cylinder is rich or lean, 
							the G Series 
							will display that too.</p>
&nbsp;<h2>Injector Analysis:</h2>
					<p>Nozzle flow uniformity is paramount to operation 
							lean of peak but only Insight delivers a nozzle 
							analysis every time you lean. G Series can forewarn of problems and assure 
							uniformity of results. Of course other systems just 
							leave you in the dark.</p>
&nbsp;<h2>G Series Data:</h2>
					<p>G Series instruments are not just temperature 
							indicators, they compute real-time results using 
							manifold pressure, RPM, fuel flow and temperatures. G Series handles the raw data to eliminate confusion 
							and provide answers. It couldn’t be easier. While constantly displaying critical information 
							during flight the G Series always work diligently 
							behind the scenes too, logging data to a handy SD 
							card for study later so nothing is missed. It’s easy to go back in time, study trends and trace 
							problems to root cause.</p>
					<H2>Innovation<span class='auto-style34' style='box-sizing: border-box; font-size: large; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>:</span></h2>
					<p>Decades ago Insight introduced the first instrument 
							to display cylinder and exhaust gas temperature of 
							all cylinders simultaneously. This innovation eventually became the industry 
							standard as all other manufacturers followed suit.Engine monitors depend on numerous temperature 
							probes that have equal potential to inform or confuse 
							when any of them fail. In fact probe failures can easily be confused with 
							engine failures. Only the G Series has a&nbsp; probe diagnostic 
							system built in.</p>
				<p class='center' style='box-sizing: border-box; margin: 0px 0px 12.5px;'>
				<br>
				<img alt='G3' height='330' src='Site/images/fullg3.png' width='331'></p>
				</div>
				<hr>
				<div>
					<h3 class='center'>Manufacturing<span class='Apple-converted-space' style='color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>&nbsp;</span>G 
				Series<span class='Apple-converted-space' style='color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>&nbsp;</span>at 
				Insight</h3>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; color: rgb(27, 53, 81); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<iframe id='I1' allowfullscreen='' frameborder='0' height='315' name='I1' src='' width='560'>
				</iframe><span class='Apple-converted-space'>&nbsp;</span>&nbsp;</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; color: rgb(27, 53, 81); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<iframe width='560' height='315' src='' frameborder='0' allow='autoplay; encrypted-media' allowfullscreen>
				</iframe>&nbsp;</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; color: rgb(27, 53, 81); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G' height='308' src='Site/images/2.25.png' style='border: 0px; max-width: 100%;' width='317'></p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G Size' height='296' src='Site/images/g123size.png' style='border: 0px; max-width: 100%;' width='600'></p>
					<p>Insight's 610C Graphic Engine Monitor (G3) color-coded bargraph 
				and digital values may be Primary for CHT, EGT and TIT. All 
				other data shown in cyan at the top of display are to be 
				supplementary.
				<br><br>Traditional multi-cylinder exhaust gas and cylinder head 
					temperature systems that force the pilot to switch or scan 
					an indicator from cylinder to cylinder in search of critical 
					engine data, are long obsolete. Using the latest computer 
					technology, the G3 presents a clear, concise, graphic 
					picture of all engine temperatures simultaneously for 
					interpretation at a glance.
					<br>
					<br>Never before has so much engine diagnostic information been 
					available to the pilot and never before, has the pilot been 
					able to control mixture with such ease and precision for 
					peak fuel efficiency.
					<br>Insight's latest G3 automatically records flight temperature 
					and will also interface with other data sources and report 
					information to other instruments like MFD’s. The data-log 
					files stored on the SD card can be easily retrieved by the 
					pilot, in-flight or post-flight, for instant viewing or 
					permanent record-keeping.
					<br>The G3 is a sophisticated tool for engine management. Its 
					microprocessor performs many tasks that used to be handled 
					by the pilot. One of the basic functions performed by the G3 
					is monitoring exhaust gas temperatures for all cylinders 
					with one degree resolution. What is important is the exhaust 
					gas temperature of a particular cylinder in relation to its 
					peak. But peak EGT is not a constant; it changes with 
					atmospheric conditions, altitude, power setting and engine 
					condition and for this reason absolute exhaust gas 
					temperatures in degrees Fahrenheit are quite meaningless.
					<br><br>The real objective of mixture management is finding a 
					mixture setting which represents the correct position on the 
					EGT/Fuel Flow Curve. As we will see later, this abstract 
					task is easily accomplished by the G3's microprocessor which 
					samples EGT's for all cylinders many times a second and 
					subjects this data to a complex mathematical analysis can 
					identify peak. This capability allows the pilot to operate 
					his or her aircraft engine at the most economical mixture 
					settings.
					<br><br>It is generally known that EGT can be a valuable source of 
					information for engine diagnosis and troubleshooting, but 
					there is a great deal of confusion when it comes to 
					interpreting this data. One of the basic principles of EGT 
					engine analysis is that engine temperatures (EGT and CHT) 
					achieve equilibrium in an engine operating at a constant 
					power and mixture setting. What is often overlooked is that 
					this equilibrium cannot be defined as a single point but 
					rather a range of temperatures.
					<br><br>The Graphic Engine Monitor (G3) is ready to operate the 
					moment electrical power is applied. Within seconds after 
					starting the engine, the white EGT bar graph columns will 
					begin to appear on the G3 display. Each column corresponds 
					to the Exhaust Gas Temperature (EGT) of a cylinder. The 
					lowest exhaust gas temperature that can be displayed by the 
					G3 is 800° F. In some engines, the throttle will have to be 
					opened to the fast idle range to get an EGT indication for 
					all cylinders. As the cylinder heads begin to warm up, the 
					display will indicate Cylinder Head Temperature (CHT) for 
					all cylinders as a smaller green bar in each EGT column. A 
					horizontal red line across each column represents the 
					maximum allowable CHT. Digital numbers below each bar graph 
					column indicates the exact EGT and CHT for each cylinder.</p>
					<h3>G4 Twin Buss Voltage</h3>
					<p>The G4 Buss Voltage attempts to display the buss voltage in 
					green when it’s normal and red when it’s outside of normal. 
					In an aircraft with a 12V electrical system the Buss Voltage 
					will be annunciated in green so long as the voltage is 12.0V 
					to 14.9V (inclusive).In an aircraft with a 24V electrical 
					system the Buss Voltage will be annunciated in green so long 
					as the voltage is 24.2V to 28.7V (inclusive). Below this 
					range the alternator isn’t charging the battery and above 
					that it’s overcharging, and the Buss Voltage will be 
					annunciated in red. The instrument must be connected to the 
					main voltage buss (not in series with something else, on a 
					lighting buss, etc.) and must have a good low-resistance 
					ground connection, otherwise the voltage measurement itself 
					will be in error causing the Buss Voltage to indicate in red 
					erroneously.</p>
					<h3>Controlling the G3 instrument</h3>
					<p>The instrument has two 
					control knobs that operate combination rotary and push 
					button switches. The top knob in general controls screen 
					selection while the bottom knob controls items within the 
					given screen. Each screen assigns its own functional needs 
					to the controls that may change depending on context. A 
					screen may also label the controls with guidance information 
					like “Push to exit”.</p>
					<h3>The Bar-Graph Display Screen</h3>
					<p>The Exhaust Gas Temperature is displayed in white bar graph form and is 
					interpreted much like a conventional mercury thermometer. 
					The higher the bar, the higher the temperature.<br>The cylinder head temperature is displayed in green single-bar format. During normal operation it shows as a green 
					illuminated bar in the lower half of the bar column. Since 
					EGT is normally higher than CHT, the green bar which 
					represents CHT is on top of the white illuminated EGT bar 
					and stands out clearly. However, when the engine is 
					shutdown, the EGT quickly drops to zero and the cylinders 
					remain warm for sometime.<br>The G3 provides a reliable indication of cylinder head 
					temperature even with the engine shut down. Should an EGT 
					probe fail, the entire EGT column for that cylinder will go 
					blank, and the numeric indication will show --- that is 
					dashes, but the CHT bar will still remain green. The failure 
					of one probe will not affect the display of any other probe.</p>
					<h3>An Easy Upgrade</h3>
					<p>A key requirement of the G3 design was compatibility with 
					previous GEM’s. We strive to never leave our loyal customers 
					behind. Packing all the functionality of the G3 in package 
					half the size of the original GEM took us to the limit of 
					our patience many times but it was worth it. Fortunately its 
					amazingly compact circuits will be built by robotic machines 
					because most of the parts are too small to handle and too 
					difficult to be seen by eye. Products like the modern cell 
					phone have driven the electronic assembly technology we use 
					a long way.</p>
					<hr>
					<div><h3>AVWeb Insider -<span class='Apple-converted-space'>&nbsp;</span><a href='http://www.avweb.com/blogs/insider/KitplanesBlog_SunNFun2008_InsightEngineMonitor_197596-1.html' style='color: rgb(51, 51, 51); text-decoration: underline;'>New 
				Insight Engine Monitor and So Much More</a>
				</h3>
				<p><em>By Rick Lindstrom</em><br>
				<br>
				Insight, the originator of the Graphic Engine Monitor, surprised 
				everyone by unveiling a new third generation GEM called<b><span class='Apple-converted-space'>&nbsp;</span>G3</b><span class='Apple-converted-space'>&nbsp;</span>at 
				Sun n Fun. By no means a luke warm sequel the<span class='Apple-converted-space'>&nbsp;</span><b>G3</b><span class='Apple-converted-space'>&nbsp;</span>is 
				a breakthrough product.Featuring a bright full color display it offers numerous screens 
				of new functionality previously unavailable anywhere. While the original lean screen is gone a vastly improved screen 
				replaces it with special functionality for lean of peak 
				operation. G3 logs data to readily available SD digital camera cards. A low 
				cost card will store decades of flight data. The new<span class='Apple-converted-space'>&nbsp;</span><b>G3</b><span class='Apple-converted-space'>&nbsp;</span>writes 
				PC compatible files and directories so no special software is 
				required to process or transfer data. Its extensive data log 
				files include flight data from Insight’s TAS-1000 air data 
				system and nav info from your GPS. Despite its enormous capabilities the new is a compact size and plug-compatible replacement for all previous 
				GEMs. Insight offers a generous GEM trade-in to make upgrades 
				easy.</p>
				</div>
				<hr>
				<h3>Restarting The Leaning Process</h3>
					<p>Restart the leaning 
				process and resetting the peak indications on G1 by short push 
				of bottom button.<br>Restart the leaning process and resetting 
				the peak indications on G2/3/4 single by a short push of the SEL 
				button.<br>Holding the SEL knob for about 3 seconds on G4 twin 
				will take you back to twin-engine screen.</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					</div>
				<img class='responsive' alt='Functions' src='New%20Images/function%20chart.jpg' width='830'>
				<hr>
				<div>
					<h2>Probe Screen</h2>
					<p>
				<img alt='G3' height='196' src='Site/images/g3_probe.jpg' style='border: 0px; max-width: 100%; float: right;' width='194'>The 
				Need for better Diagnostic Tools</p>
					Even the first GEM could detect an open probe and blank its 
				indication. Over the years by helping owners and their mechanics 
				trouble shoot instrument problems I developed a new 
				understanding and sympathy for the challenge they faced.<br><br>Troubleshooting avionics is an expensive and time-consuming 
				process. Often times the procedure requires access to the 
				instrument connector for continuity measurements. This might 
				take hours of instrument panel disassembly just to touch the 
				connector. We needed something better, easier to use, less time 
				consuming and therefore less expensive. <br><br>Why not have the instrument diagnose itself? Then you don’t have 
				to disassemble the airplane or even touch the wiring. This is 
				not as easy as it might seem. Adding resistance measurement 
				hardware for each and every probe wire would more than double 
				the complexity of the measurement system. I considered this 
				carefully during the development of the GEM-610 second 
				generation instrument. It would at least add a second PC board 
				to the instrument and have even greater adverse impact on the 
				GEMINI twin version. Even if we endured these problems to get 
				the information we had no practical way to display it on an 
				orange bar display. <br><br>So I abandoned it then, but revisited again this time. The new 
				color display was certainly adept at displaying the information, 
				eliminating that problem, but the resistance data was still hard 
				to get.<br><br>So this time I was able to invent a new way of measuring 
				resistance. The simple idea worked beautifully without adverse 
				impact on the design. It was so simple in fact even I was 
				skeptical at first.Without this simple breakthrough we’d still be diagnosing things 
				the hard way.
					<h4>So what does the diagnostic system do?</h4>
					<p>The probe diagnosis page indications are in 
								green for normal readings and red for readings 
								that fail the criteria set at the bottom of the 
								screen.&nbsp;</p>
					<p>Each temperature probe consists of two wires, a 
								positive lead and a negative lead. The two 
								numbers next to each identifier show the 
								resistance in Ohms of each lead.<span class='Apple-converted-space'>&nbsp;</span><br>
					For example, the line EGT1 8 3 means the 
								positive lead of the EGT1 probe has 8 Ohms 
								resistance, and the negative lead has 3 Ohms 
								resistance.</p>
					
					<p>When the probe is new, it will have relatively 
								low resistance.<span class='Apple-converted-space'>&nbsp;</span><br>
					As the probe ages, it’s resistance will slowly 
								go up. Eventually, the probe will measure 
								outside the pas/fail criteria you set at the 
								bottom of the screen, and change from green to 
								red, indicating that the probe should be 
								replaced before it fails and leaves you with no 
								temperature reading at all.</p>
					<p class='style125' style='padding: 5px; margin: 0px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					<img alt='G3' height='220' src='Site/images/G3_probe2.jpg' style='border: 0px; max-width: 100%;' width='474'><br>
					</p>
					<p>One other point to consider is that the longer 
								the wiring to the probes, the higher its 
								resistance.<span class='Apple-converted-space'>&nbsp;</span><br>
					Every foot of EGT wire adds 1.7 Ohms/ft for the 
								+ lead and 0.8 Ohms/ft for the - lead. Every 
								foot of CHT wire adds 0.8 Ohms/ft for the + lead 
								and 1.2 Ohms/ft for the - lead.&nbsp;<br>
					A 24 ft harness will fail the criteria that an 8 
								ft harness will pass with. That is why we allow 
								the user to modify the pass/fail criteria on the 
								bottom of the screen.</p>
					<p>The meaning of the 
								pass/fail criteria is as follows:<br>R MAX sets the maximum resistance (in Ohms) that 
								any single lead may have. If the R MAX is set to 
								20 Ohms a probe with either the positive or 
								negative leads measuring greater than 20 Ohms 
								will be annunciated in RED, otherwise its 
								displayed in GREEN.<br>R DIF sets the maximum resistance (in Ohms) that 
								the positive lead may differ from the negative 
								lead. If R DIF is set to 10 Ohms, the positive 
								and negative leads need to measure within 10 
								Ohms of each other to be annunciated in GREEN, 
								otherwise it is RED</p></div>
&nbsp;<hr>
					<div><h2>EGT Variation Screen -	
					<a href='eva.htm'>View Mag Ad.</a>
					</h2>
				<h3>
				<img alt='EGT' height='241' src='Site/images/G3spectrum.png' style='border: 0px; max-width: 100%; float: right;' width='242'>This 
				is a new form of engine analysis.</h3>
				<p>Some valve related engine faults produce a slow periodic 
				variation in EGT. The oscillation rate is on the order of one cycle every minute 
				or two. This is just too slow to be identified by occasional 
				observation of the temperatures alone. Yet it is very important 
				to discover this phenomenon because it may lead to a 
				catastrophic engine failure. It readily appears in a slow 
				sampled spectrum analysis.&nbsp;<br><br>Temperature samples are collected once per second for each 
				cylinder and analyzed each second. The entire sample interval is 
				about 8 minutes. A normal indication will be a flat line with a 
				little noise, while a trouble indication will show as an obvious 
				spectral peak.</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='EGT' height='242' src='Site/images/g3spectrum2.png' style='border: 0px; max-width: 100%;' width='242'></p>
				</div>
				<hr>
				<div>
					<h2>Vibration Screen</h2>
					<h3>New Capabilities for the Next Generation G3 GEM</h3>
					<p>If you take a step back from the EGT/CHT idea to explore engine 
				monitoring in general, you discover that at least half the 
				engine monitoring solution is missing. EGT analysis reveals 
				combustion phenomenon but simply ignores mechanical problems.</p>
					<p>By the time a mechanical problem shows up in EGT, if it ever 
				does, the damage is done and it is far too late to do anything 
				about it.</p>
					<p>Vibration analysis is the key to pre-emptive detection of 
				mechanical problems.</p>
					<p>Following the update of the G3 Graphic Engine 
				Monitor to V1.78 or higher, the Vibration Analysis screen will 
				now appear among the supplementary screens when the PG knob is 
				turned. In order for the vibration analysis to function your G3 
				must be equipped with a vibration sensor and a connection to the 
				magneto for RPM measurement. If 
				your instrument was purchased prior to September 2011, Insight 
				will be sending you a vibration sensor shortly. Instruments 
				purchased after this date will ship with the sensor included 
				with the main kit.</p>
					<p>After the electrical connections to the 
				sensor are made, then sensor may be tested simply by powering up 
				the G3 and vibration sensor. It is not necessary to start the 
				engine to perform this test. The sensor LED should flash briefly 
				and rapidly when power is first applied until communication is 
				established with the G3, at which time the LED blinks more 
				slowly (approximately once per second). When the LED indicates 
				communications with the G3 has been established select the 
				Vibration Analysis screen by turning the PG knob. While 
				observing the vibration graph disregard the “RPM Required” 
				message and rap lightly on the vibration sensor with the handle 
				of a screw driver. The graph should register the impacts.</p>
					<p>The sensor should then be firmly mounted 
				directly to the engine case, preferably oriented in such a 
				manner as to match the small airplane symbol engraved on the 
				sensor body. In some rare cases it may not be possible to mount 
				it in this manner, and the installer will have to fabricate an 
				appropriate bracket or else be prepared to compensate for the 
				change in orientation when viewing the vibration data. A 
				representative installation is shown in the following figure:</p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='Sensor' class='style131' height='240' src='Site/images/vib-sensor4.jpg' style='border: 1px solid; max-width: 100%;' width='360'></p>
					<h4>
					Using the Vibration Analysis Screen on the 
				G3:<o:p></o:p></h4>
					<p>
				<span lang='EN-US'>The sensor detects vibration in all 3 axis 
				(fore-aft labeled x, up-down labeled z, and left-right labeled 
				y) which are presented on different sub-screens. The vibration 
				analysis only functions when the engine is running and a valid 
				rpm signal is detected.</span></p>
					<p>
				<span lang='EN-US'>In regards to the vibration graph, the 
				vertical axis represents the amount of vibration energy and the 
				horizontal axis represents the frequency spectrum expressed as 
				multiples of crankshaft rpm. When the engine is running, the 
				screen will come alive with a waveform that represents the 
				engine motion, presented in a spectral format with the 
				crankshaft energies appearing at the 1x mark on the bottom 
				scale. Propeller vibration will likewise be synchronous with the 
				crankshaft vibration. Other sources of vibration will tend to 
				produce energies at other frequencies.</span></p>
					<p>
				<span lang='EN-US'>For example, camshaft vibration tends to 
				accumulate at the .5x mark, since the cam turns at 1/2 the rate 
				of the crankshaft. Magneto vibration will appear at 1.5x mark in 
				a 6-cylinder engine. Alternator vibration may appear somewhere 
				around 3x or 4x, depending on the ratio it is driven at.</span></p>
					<p>
				<span lang='EN-US'>A gear-driven alternator may appear in a 
				different axis than the crankshaft does<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>if 
				it is mounted at 90deg to the engine, although ANY source of 
				vibration will show some energy in all three axis. Complex 
				vibration as generated by reciprocating machinery will also 
				produce a great number of harmonic spikes, which at first glance 
				may seem confusing. The user should experiment with running the 
				engine at different power settings under different conditions to 
				get a feel for what is a 'normal' spectrum for their particular 
				engine.<span class='Apple-converted-space'>&nbsp;</span><span>&nbsp;</span>A 
				simplified case of vibration is shown in the following figure:</span></p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G3 Vibration' height='201' src='Site/images/g3vibration.png' style='border: 0px; max-width: 100%;' width='202'></p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
					<p>In the example shown above the main source of 
				energy is at the 1x mark, and represents the crankshaft rpm. The 
				smaller spikes at the 0.5x mark and the 1.5x point are probably 
				created by the camshaft and the magneto, respectively. The user 
				should be aware that a multi-cylinder reciprocating engine 
				produces energies at a multitude of frequencies and directions, 
				which reinforce and subtract from each other to create a very 
				complex waveform. It is the responsibility of the user to gain 
				familiarity with a waveform that is typical of their particular 
				engine, so that unusual readings can be detected and 
				interpreted.</p>
					<p>The user may examine the various sub-screens 
				by pushing the top button (PG). There are presently six screens 
				to examine, each of the primary axis (X,Y and Z) and an averaged 
				version of each (denoted Ax, Ay, and Az). The averaged version 
				will be much 'cleaner' and contain less noise than the raw 
				measurement and is the preferred screen to examine for each 
				axis. The bottom knob (SEL) controls a cursor which will 'snap' 
				to nearby vibration spikes to make it easy to examine them 
				closer. The bottom knob can also be pushed to enter a zoom mode. 
				When in zoom mode, turning the bottom knob will allow you to 
				scroll through the waveform. Continue to press the bottom knob 
				to set progressively higher zoom modes. A further press when at 
				maximum zoom will return you to the overall view.</p>
					<p>Pressing and holding the PG button will 
				trigger the G3 to save the present vibration waveform for future 
				reference. The waveform will be stored as a series of 
				hexadecimal bytes in the current log file. Insight can provide a 
				tool for examining this waveform using Excel or a similar 
				spreadsheet. The tool is presently in the earliest functional 
				stages of development, and will be improved over time.</p>
					<p>It is expected that the vibration functions 
				will be used as a 'condition-monitoring tool'. Since every 
				engine and accessory combination is different, everyone's 
				vibration spectrum will look unique and it would be impossible 
				to generalize the interpretation of the spectrum. The user will 
				come to recognize what a 'normal' spectrum looks like for their 
				engine and by periodically scanning the vibration screen can 
				recognize when potential trouble is developing. When a new spike 
				appears or an existing spike begins to show signs of higher than 
				normal amplitude further investigation is warranted. The source 
				of the spike can be interpreted by noting its primary axis and 
				its frequency relative to crankshaft RPM as discussed above. By 
				periodically saving their vibration data as discussed above, the 
				user can create a database of reference waveforms for future 
				comparison.</p>
				<span class='style149' style='color: rgb(0, 0, 0); font-size: small; font-family: Arial, Helvetica, sans-serif; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				</span>
				<hr>
					<p><em>While in-flight with the vibration screen showing on G3, Pressing and holding the PG button will trigger the G3 to save 
				the present vibration waveform for future reference.</em></p>
					<div class='center' style='color:red'>
						<strong>Hold PG button in until G3 screen says it is data logging 
				vibration data.</strong></div>
				</div>
				<span class='style149' style='color: rgb(0, 0, 0); font-size: small; font-family: Arial, Helvetica, sans-serif; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				<hr></span>
				<H3>
				<strong style='font-weight: bold !important;'>Take Off G Force 
				Screen</strong></h3>
				<font class='style158' size='1' style='font-size: small;'>
				<span class='style149' style='color: rgb(0, 0, 0); font-size: small; font-family: Arial, Helvetica, sans-serif; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G3' height='189' src='Site/images/g3takeoff.png' style='border: 0px; max-width: 100%;' width='189'></p>
				<hr></span></font>
				<h3>
				<strong style='font-weight: bold !important;'>Turbulence Display 
				Screen</strong></h3>
				<h1 class='text-center' style='color: rgb(0, 0, 0); margin: 0px; padding: 0px; font-weight: normal; font-size: 11px; letter-spacing: normal; text-align: center; font-family: Verdana, Arial, Helvetica, sans-serif; text-shadow: rgba(0, 0, 0, 0.0980392) 1px 1px 1px; font-style: normal; font-variant: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<img alt='G3' height='261' src='Site/images/G3%20axis.jpg' style='border: 0px; max-width: 100%; float: right;' width='256'></h1>
				<h1 class='style126' style='color: rgb(0, 0, 0); margin: 0px; padding: 0px; font-weight: normal; font-size: small; letter-spacing: normal; font-family: Arial, Helvetica, sans-serif; text-shadow: rgba(0, 0, 0, 0.0980392) 1px 1px 1px; text-align: left; font-style: normal; font-variant: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				&nbsp;</h1>
				<p>The G3-4 contains a 3-axis accelerometer sampled at modest rates 
				to measure turbulence and landing shock. Knowledge of G forces will help the pilot to operate the 
				airplane safely by slowing to maneuvering speed. Landing shock 
				is a good training aid for smooth landings and a predictor of 
				structural damage. Data logged G force will report unauthorized aerobatic activity 
				or abuse of rental aircraft. It could also be useful in accident 
				investigation.</p>
				<p style='padding: 5px; margin: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<br><br></p>
				<hr style='color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<h3>Measuring Horse Power Screen</h3>
				<p>
				<img alt='HP' height='269' src='Site/images/HP2.jpg' style='border: 0px; max-width: 100%; float: right;' width='270'>On 
				a test stand engine horsepower is derived by measuring the 
				twisting force (torque) that the engine exerts on a load.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>In 
				fact horsepower is defined as simply the product of torque times 
				RPM.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>Therefore 
				if our piston engines were equipped with real torque transducers 
				we could utilize RPM and compute real horsepower. While such 
				torque transducers are commonly used to calibrate turbo-prop 
				engines they actually cost more than a typical piston engine. 
				Sadly there is no practical way to directly measure horsepower 
				in a piston aircraft engine.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>But 
				this hasn’t stopped at least one engine instrument manufacturer 
				from making bogus claims to the contrary!<o:p></o:p></p>
				<p>REMEMBER: There is no 
				practical way to truly measure horsepower.<o:p></o:p></p>
				<p>If you planned to use your horsepower display to gauge take off 
				performance or measure engine health you can forget it. In fact, 
				dynamometer tests of so-called horsepower displays revealed NO 
				CHANGE in indicated “horsepower” even when individual cylinders 
				were completely disabled!</p>
				<o:p></o:p>
				<h3>The Insight Approach to Power</h3>
				<p>Despite some limitations we elected to put a power display in 
				the G3 graphic engine monitor. To 
				prevent any misconceptions we called it “Theoretical 
				Horsepower”, and under certain conditions it actually does a 
				pretty good job of reporting horsepower. One dependable metric 
				of power is fuel consumption. At peak EGT and leaner where ample 
				or excess oxygen available to consume the available fuel 
				horsepower is a linear function of fuel flow. At richer mixtures 
				where some fuel remains unconsumed and doesn’t contribute its 
				full power potential the simple linear relationship falls apart. 
				Prior to leaning to peak the display is challenged to deliver an 
				accurate horsepower display but once peak has been reached the 
				rich-of-peak accuracy will improve.</p>
&nbsp;<p>One limitation of the fuel method is that it is not sensitive to 
				engine faults that can significantly affect the power produced. 
				For example, a cylinder without ignition won’t combust the fuel 
				to produce power, but will nevertheless continue to consume it. 
				So don’t expect to diagnose engine performance issues with the 
				fuel flow approach to horsepower calculation.<o:p></o:p></p>
				<p>What good is a fuel flow based horsepower calculator? The 
				intended purpose of the theoretical horsepower display is to 
				provide an indication of power for leaning purposes. For 
				example, lean-of-peak operation is not recommended at power 
				settings greater than 65%. It 
				is interesting to see the reduction in horsepower that 
				accompanies lean of peak operation.</p>
				<h3>The Insight Approach to Performance Measuring</h3>
				<p>While the G3 does not directly measure true horsepower 
						(remember that no engine monitor does) it does measure 
						the EFFECT of horsepower on takeoff acceleration. This 
						information is displayed on the “Take Off Performance” 
						screen and recorded in the log file too. Acceleration is 
						direct function of engine thrust and other factors like 
						weight, runway conditions, slope and even tire pressure. 
						Of course, ambient conditions like altitude and 
						temperature will affect engine power and therefore take 
						off performance.</p>
				<hr>
				<div>
					<h2>Insight announces the next big breakthrough in engine 
					monitoring</h2>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-weight: bold; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G3' height='189' src='Site/images/g3interface.png' style='border: 0px; max-width: 100%;' width='189'></p>
				<span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'>
				</span>
				<p>In&nbsp;G 
					Series Software<span class='Apple-converted-space'>&nbsp;</span>Version 
					208&nbsp;the 
					G3-4<span class='Apple-converted-space'>&nbsp;</span>has 
					a new page that displays data received from the TAS-1000.</p>
				<p>The GEM's data-logging capabilities can be extended by 
					receiving air data from a TAS-1000 air data computer. This 
					page shows real-time air data which includes True Airspeed, 
					Pressure Altitude, and Wind Speed and Wind Direction all of 
					which are recorded in the GEM's data log along with engine 
					and fuel data.</p>
				<div align='left'>
					<p style='padding: 5px; margin: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					&nbsp;</p>
				</div>
				<p class='style126' style='padding: 5px; margin: 0px; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'>
				<img alt='TAS-GPS' height='282' src='Site/images/g3%20tas%20gps2.png' style='border: 0px; max-width: 100%;' width='425'></span></p>
				<p class='style126' style='padding: 5px; margin: 0px; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p>Insight’s G3-4 is now capable of receiving RS-232 serial 
					data from our TAS-1000 MFDS that includes Indicated Air 
					Speed, True Air Speed, Pressure Altitude, True Air 
					Temperature, Wind Direction, Wind Speed, and Heading in the 
					data log file on every flight.</p>
				<p>While the detail in the G3-4 data log is unprecedented – now 
					it is even better.</p>
				<p>The G3 engine log system has been transformed to a complete 
					aircraft performance logging system.</p>
				<p>Now you can log aircraft performance data right along with 
					your engine data.</p>
				<p>The missing link in data log analysis is finally available.</p>
				<p>Now you can really tell what’s happening. Much of the 
					black-box functionality previously available only in Jets is 
					now available to you.</p>
				<p>The key to operating your aircraft efficiently is 
					understanding its performance. Now every data log is like a 
					performance chart from the flight manual but it is specific 
					to your aircraft and actual conditions.</p>
				<p>Don’t forget about the Insight TAS 1000’s ability to fill in 
					your GPS pages with real-time air data, fuel, wind data page 
					and also with wind arrow and wind speed on your moving map.</p>
				<p>With no TAS the G3-4 displays 
				only OAT (Outside Air Temperature) but with 
				a TAS-1000 the missing link in data log analysis is finally available.<br>
				</p>
				<p class='style126' style='padding: 5px; margin: 0px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-align: center; color: rgb(0, 0, 0); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; line-height: normal; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='TAS-1000' height='145' src='Site/images/tas1000.png' style='border: 0px; max-width: 100%;' width='230'></p>
					<p>With the TAS installed in addition to OAT the G3-4&nbsp;displays 
				also displays</p>
					<ul>
					<li>TAT (Total Air Temperature)</li>
					<li>IAS (Indicated Air Speed)</li>
					<li>TAS (True Air Speed)</li>
					<li>ALT (Pressure Altitude)</li>
					<li>WD (Wind Direction)</li>
					<li>WS (Wind Speed)</li>
					<li>HDG (Heading)</li>
				</ul>
				</div>
				<hr style='color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<h2>Turbulence and Hard Landings:</h2>
				&nbsp;Now 
				we go back in time to capture a turbulent transient or a landing 
				event.<span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'><span lang='EN-US'>&nbsp;</span></span>In the miscellaneous configuration screen the 
				pilot can now set the threshold for the vertical axis G-force. Every time this threshold is exceeded the 
				G3/G4 records a 12 second interval of the turbulence in the log 
				file. These twelve seconds consists of data from 
				the 6 seconds before the event and the 6 seconds after it.&nbsp;There are two new screens between Two Axis 
				Turbulence and Takeoff G-force which display live G-force and a 
				snapshot of the G-Force from last event (threshold exceeded).				<span lang='EN-US'>User can view a graph of the last 12 seconds 
				of live data or view the last captured event.</span> <br>This feature will also capture hard landings.				<span lang='EN-US'>
				<br>The graph is automatically scaled for maximum 
				zoom based on threshold.&nbsp;&nbsp;When 
				the threshold is exceeded the 12 second G-force is also recorded 
				in the log file.</span><br>The new transient G-force screen shows you the whole 
					event the moment it happens. You won’t miss a thing.&nbsp;<br>
				<br>The event is also marked and stored in the log file for 
					easy reference later.&nbsp;<br><br>The pilot can set the trigger threshold on the G-force 
					screen for normal operation. Just prior to landing the 
					instrument automatically resets that threshold to always 
					capture the landing event. Just 6 seconds after touch down a 
					high resolution picture of the landing is available.&nbsp;<br>
				<br>It is all automatic and couldn’t be easier.&nbsp;<br><br>This new feature is available on all new G3 &amp; G4 
					instruments and is available at no charge to all current 
					customers in the latest update.&nbsp;<br><br>Just download and update your instrument from our web 
					site.&nbsp;<p class='text-center' style='text-align: center; padding: 5px; margin: 10px; color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G4' height='246' src='Site/images/dynamic.png' style='border: 0px; max-width: 100%;' width='246'>&nbsp;<span class='Apple-converted-space'>&nbsp;</span><img alt='G4' height='238' src='Site/images/g4snapshot.png' style='border: 0px; max-width: 100%;' width='239'></p>
				<h2>User Configuration</h2>
				<p class='auto-style6' style='text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: x-large; padding: 5px; margin: 10px; color: rgb(85, 85, 85); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<span class='style144' style='font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-size: xx-large; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				<img alt='G4' height='245' src='Site/images/user.png' width='257'></span></p>
				<p class='auto-style6' style='text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: x-large; padding: 5px; margin: 10px; color: rgb(85, 85, 85); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<span class='style126' style='font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: Arial, Helvetica, sans-serif; color: rgb(0, 0, 0); line-height: normal; orphans: 2; widows: 2; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				<span class='auto-style1' style='font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>G3-G4 have same screens</span></span></p>
				<p>Using the knobs to 
							navigate the G3-4:<br><br>The G3-4 has two knobs: PD 
							select page and SEL work within page. There are two 
							functions built into each knob; the push button 
							switch activated by pressing the knob in, and the 
							selection is activated by turning the knob either 
							clockwise or counter clockwise.<br><br>The PG knob 
							is used to select the various screens. From the main 
							temperature bargraph screen turn the PG knob counter 
							clockwise 2 clicks to get to the User Configuration 
							screen. Once you are there you do not use the PG 
							knob any more because turning it takes you away from 
							the User Configuration screen.<br><br>The SEL button 
							is pressed to select a line for adjustment. When you 
							first enter a screen by default no line is selected. 
							Pressing the SEL button once selects line 1. The 
							selected line is shown in yellow. Pressing it a 
							second time selects line 2. On any line with 
							multiple selections the selected item will be shown 
							in red.<br><br>Setting up the G3 Temperature 
							Bargraph Display:<br><br>On the User Configuration 
							screen there are some options for setting up the 
							temperature bargraph display. There are three 
							different ways to accomplish this. One method is to 
							use the Auto range function to configure the display 
							for you. <br>Another method is to adjust the MAX EGT 
							TEMPERATURE and AUTORANGE INFLECTION parameters 
							manually, and a third method is to set the bar 
							heights visually on the main screen.<br><br>On line 
							2 (EGT AUTORANGE) there are 3 possibilities ON OFF 
							and SAVE. After pushing the SEL button until this 
							line is highlighted in yellow, the SEL knob may then 
							be turned to make a selection on this line. When on 
							line 2 turning the SEL knob fully counter clockwise 
							selects nothing. From there turning the SEL knob one 
							click clockwise selects ON. The current selection is 
							shown in red. Turning the SEL knob another click 
							clockwise selects OFF. And one more turn clockwise 
							selects SAVE.<br><br>Using the Auto Range function 
							(Method 1):<br><br>To turn OFF the auto range 
							capability on the User configuration screen:<br><br>Press the SEL button twice to select line 2 (EGT 
							AUTORANGE).<br>Turn the SEL knob to select OFF on 
							line 2.<br>Press the SEL button to select line 7 
							“SAVE CONFIG”<br>Turn the SEL knob to select YES on 
							line 7.<br>Press the SEL knob to save the choice.<br>We have now turned off auto ranging.<br>
				<br>To turn 
							ON the auto range capability on the User 
							configuration screen:<br>Press the SEL button to 
							select line 2. (EGT AUTORANGE).<br>Turn the SEL knob 
							to select ON on line 2.<br>Press the SEL button to 
							select line 7 “SAVE CONFIG”<br>Turn the SEL knob to 
							select YES on line 7.<br>Press the SEL knob to save 
							the choice.<br>We have now turned on auto ranging.<br>
				<br>In order to use the 
							auto range function it must be turned on as 
							described above. Once this function is enabled, the 
							G3-4 will automatically adjust the EGT MAX 
							TEMPERATURE and AUTORANGE INFLECTION to be 
							appropriate for the highest temperature reported by 
							the probes. <br>You should now take the airplane and 
							perform a typical flight. <br>The G3-4 will analyze 
							the EGT temperatures and scale the temperature bars 
							as required so that the entire temperature range 
							measured by the EGT probes is displayed on the main 
							bargraph screen. <br>It is important to realize that 
							so far this adjustment is temporary. If we want it 
							to remain permanent we must return to the User 
							Configuration screen.
							<br>
							<h4>To save the results of auto ranging:</h4>
							<ul>
					<li>Press the SEL button to select line 2 (EGT AUTORANGE).</li>
					<li>Turn the SEL knob to select SAVE on line 2.</li>
					<li>Press the SEL button to	select line 7 “SAVE CONFIG”</li>
					<li>Turn the SEL knob to select YES on line 7.</li>
					<li>Press the SEL knob to save the choice.</li>
					<li>The results are saved, and auto ranging is turned OFF.</li>
				</ul>
				<p>The main temperature 
							bargraphs should now be scaled properly for this 
							individual airplane on all subsequent flights.<br>Auto ranging may be turned on and the range 
							relearned as often as desired.<br></p>
				<h4>Setting up the 
							G3 Temperature Bargraph display manually (Method 2):</h4>
				<p>In some cases it may be desirable to set or 
							refine the temperature bargraph screen manually. <br>To do so, return to the User Configuration screen 
							and make sure EGT AUTORANGE is turned OFF as 
							described earlier. Adjust EGT MAX TEMPERATURE and 
							AUTORANGE INFLECTION directly by using the following 
							procedure:<br>To set an EGT MAX TEMPERATURE and AUTORANGE 
							INFLECTION on the User configuration screen:<br>Press the SEL button to select line 3 (AUTORANGE 
							INFLECTION) or line 4 (EGT MAX TEMPERATURE).<br>Turn 
							the SEL knob to select a value as desired. Notice 
							that adjusting the AUTORANGE INFLECTION affects the 
							value of EGT MAX TEMPERATURE and vice versa.<br>Press the SEL button to select line 7 “Save Config”<br>Turn the SEL knob to select YES on line 7.<br>Press 
							the SEL knob to save the choice.</p>
				<h4>AUTORANGE INFLECTION and EGT MAX TEMPERATURE explained:</h4>
				<p>The Autorange Inflection point is the point 
							along the temperature graph at which the scale of 
							the bars change. <br>Below the inflection point (ie, 
							at low temperatures) readings are displayed with a 
							coarse resolution (the bars go up/down a small 
							amount for a relatively large change in 
							temperature). <br>Above the Inflection Point (at 
							higher temperatures than the Inflection Point) the 
							bars are displayed in a higher resolution (the bars 
							go up/down more for a small change in temperature).
							<br>The net effect is that the dynamic range of the 
							temperature bargraph is increased. In other words, 
							we can show temperatures all the way down to room 
							temperature on the bargraph yet still show small 
							changes in temperature at the airplane’s operating 
							temperature range. <br>As an example if we set our 
							Autorange Inflection to be 1200 deg then 
							temperatures below 1200 will be rendered with 
							relatively few pixels/degree whereas temperatures 
							above 1200 will be rendered with more pixels/degree 
							to make temperature changes more obvious.<br>
				The EGT Max 
							Temperature simply defines the temperature that is 
							represented by a bar that is full screen in height. 
							For example if EGT Max Temperature is set to 1600 
							deg than a temperature of 1600 deg will be rendered 
							as a bar that reaches the top of the screen.<br>The G3’s Autorange Inflection is always 400 deg 
							below the EGT Max Temperature. Adjusting one will 
							therefore always affect the other automatically.</p>
				<h4>EGT Smoothing</h4>
				<p>The lower the number the faster 
							the sampling but less smooth (jumpier)<br>The factory 
							preset is 32.</p>
				<h4>Adjusting the bar heights 
							from the main screen (Method 3):</h4>
							<p>An alternative way to setup the scale of the 
							temperature bargraphs can be performed from the main 
							screen. <br>Press the SEL button and a message 
							appears: “TURN-ADJUST BAR HEIGHT”. <br>By turning 
							the SEL button the heights of the bars may be moved 
							up and down. <br>Pressing the SEL button twice more 
							returns the G3-4 to its normal mode. <br>If we 
							return to the User Configuration screen, we will see 
							that EGT MAX TEMPERATURE and AUTORANGE <br>INFLECTION have been adjusted to reflect our changes 
							to the bar height. <br>If the adjustment is to 
							become permanent we must select Save Config and set 
							it to yes.</p>
				<hr style='color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<div>
					<h2 style='color:red'>NEW Fuel Screens</h2>
					<p>
					<h3><strong>Previously, there was no standard color scheme in 
					the configuration screens.</strong></h3>
					<p>Now, the selected line is yellow and the inactive lines are white. <br>YES/NO 
					in red has been removed by displaying only the word YES or 
					the word NO in green, when saving. <br>When there is a 
					choice of several items the selected item is displayed in 
					green. <br>Exactly one item is always selected. <br>The 
					choices of temperature units are Celsius or Fahrenheit then 
					either Fahrenheit or Celsius will be selected in green.</p>
					<h3>
					<strong>The FUEL TOTALIZATION screen has been improved and is 
					even easier to use.</strong></h3>
					<p>This change allows the pilot to see this screen before entering fuel on board. 
					<br>Also setting initial fuel can be checked and corrected in 
					flight. <br>Previously the pilot had to enter the amount of 
					fuel onboard before he could view the Fuel Totalization 
					page. <br>Now both the FUEL TOTALIZATION page and the 
							<strong>FUEL 
					SETUP</strong> page are accessible at any time. <br>On the 
							<strong>FUEL 
					TOTALIZATION</strong> screen simply press the PG (left) button to 
					enter fuel, press it again when done. As before you can 
					top up the tank(s) by turning the SEL (right) knob counter 
					clockwise on the very first click.</p>
					<h3><strong>Set total fuel onboard before take-off</strong></h3>
					<p>Your G2-3-4 was preset at factory with your usable 
					total fuel</p>
					<h4><em><strong>To reach the FUEL TOTALIZATION 
					screen from the main screen:</strong></em></h4>
					<ul><li>Turn the PG knob counterclockwise one click.</li>
						<li>Push PG knob to go back and forth between the 
						<strong>FUEL SETUP</strong> and <strong>FUEL TOTALIZATION</strong> screens</li> 
						<li>On FUEL SETUP screen setting fuel gallons the lines FUEL ADDED, SUBTOTAL and FUEL NOW color will be yellow. </li>
						<li>Turn SEL knob to set gallons (Clockwise or 
					Counterclockwise one click for total preset total fuel for 
					your aircraft) </li>
						<li>At any time, you can push PG knob to go back and forth 
					between the <strong>FUEL SETUP</strong> and <strong>FUEL TOTALIZATION</strong> screens to add 
					more fuel.</li></ul>
					<p class='style131' style='padding: 5px; margin: 0px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>&nbsp;<span class='Apple-converted-space'>&nbsp;<img alt='G4' height='243' src='Site/images/fuel1.png' width='251'><img alt='G4' height='245' src='Site/images/fuel2.png' width='258'></span></p>
					<p class='style131' style='padding: 5px; margin: 0px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>G3-G4 have same screens</p>
					<p style='padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					&nbsp;</p>
					<h4><strong style='font-weight: bold !important;'>FF Stability</strong></h4>
					<p>Displays, literally, the stability of your fuel flow over 
					the last few seconds. The smaller the number, the less the 
					fuel flow has varied in the past few seconds. A 
					well-regulated fuel system will have a small number, a 
					carbureted system can expect a larger number. The smaller 
					the number the more likely you are to get an accurate fuel 
					flow reading during the lean-find function. An larger number 
					will make things more difficult.</p>
					<h4><b>GEM FUEL TOTALIZER CAUTIONARY NOTICE<o:p></o:p></b></h4>
					<p>The Fuel Remaining display on the GEM is very useful but is 
					not without limitations. Understand first that the factory 
					fuel quantity gauges are the only instruments in the panel 
					that physically measure fuel level. They are still the 
					primary indication of fuel level in the airplane.</p>
					<p>The GEM doesn’t measure level, but instead measures only 
					fuel flow rate. The GEM totalizes the rate information to 
					account for fuel used. If you know how much fuel you started 
					with and how much you have used you can figure fuel 
					remaining by simple subtraction.</p>
					<p>The pilot must supply an accurate starting fuel level for 
					this subtraction to produce the correct fuel remaining 
					result. Should the pilot overstate the fuel quantity on 
					board, the GEM will dangerously overstate the fuel remaining 
					and the endurance time as well. The pilot must be careful 
					and diligent when setting the fuel on board.</p>
					<p>Getting the correct fuel total on board is in many cases 
					pretty easy. If you fill up prior to takeoff the number is 
					obviously the total available on board. If you partially 
					fill a known configuration (say tips empty) then the total 
					is easy to calculate. If you partially fill fuel tanks or 
					add an accurately know quantity to a poorly known original 
					value - errors will abound. Unaccounted fuel loss from 
					leakage, fuel vent overflow or theft will of course produce 
					erroneous results. So be careful and the GEM will deliver 
					safe, reliable, and convenient fuel information. But be sure 
					to cross reference the information on the primary fuel 
					quantity gauges. Never trust a single source of fuel 
					information when you have two on board. Fuel exhaustion 
					still ranks highly among accident causes. Don’t let your 
					engine stop until you’re parked.</p>
				</div>
				<div class='center'>
					<br><a href='#top'>
					<img alt='Top' height='40' src='Site/icons/back-top.png' width='100'></a></div>
				<p>&nbsp;</p>
				<!--/body content --></div>" },
                   new Product() { ProdName = "G4 Engine Monitor", ProdShort="G4", ProdDesc = "•3.125” Bezel•VFR - IFR•4 Or 6 Cylinder•Injected & Turbo•Backseat Readable•Running Serious LOP•Exhaust Valve Analysis", ProdBody = @"
				<H2 class='center'><strong>Here's why you should install
							<span class='red-text'>G4</span>:</strong></h2>
				<div>
				<h2>Leaning:</h2>
					<p>G Series is the best technology available, there’s nothing else like it, nothing even comes close. Operation lean of peak requires special information that only the G3 or G4 graphic Engine Monitor can provide.	The G Series instruments are extraordinarily capable yet easy to use. G Series specialized innovative leaning process is the first and only one to ever earn a patent,	<a href='pdf%20files/G3%20Manuals/G%20Series/G%20Series%20Patent.pdf'>which may be read here.</a>
					<br>Unprecedented in its sophistication, most 
							importantly it makes a complex process easy to 
							accomplish. Leaning with reference to temperature only is just 
							too confusing for LOP. Our specialized process reports each individual 
							cylinders status in unambiguous form. You needn’t 
					ponder if a cylinder is rich or lean, the G Series will 
					display that too.</p>
					<H2>Injector Analysis</h2>
					<p>Nozzle flow uniformity is paramount to operation 
							lean of peak but only Insight delivers a nozzle 
							analysis every time you lean. The
					G Series can forewarn of problems and assure 
							uniformity of results. Of course, other systems just 
							leave you in the dark.</p>
							<h2>G Series Data</h2>
					<p>G Series instruments are not just temperature 
							indicators, they compute real-time results using 
							manifold pressure, RPM, fuel flow and temperatures.
					G Series handles the raw data to eliminate confusion 
							and provide answers. It couldn’t be easier. While constantly displaying critical information 
							during flight the G Series always work diligently 
							behind the scenes too, logging data to a handy SD 
							card for study later so nothing is missed. It’s easy to go back in time, study trends and trace 
							problems to root the cause.</p>
							<h2>Innovation</h2>
					<p>Decades ago Insight introduced the first instrument 
							to display cylinder and exhaust gas temperature of 
							all cylinders simultaneously. <br>This innovation eventually became the industry 
							standard as all other manufacturers followed suit.
					<br>Engine monitors depend on numerous temperature 
							probes that have equal potential to inform or confuse 
							when any of them fail. In fact probe failures can easily be confused with 
							engine failures. Only the G Series has a&nbsp; probe diagnostic 
							system built in.</p>
				<p class='center' style='box-sizing: border-box; margin: 0px 0px 12.5px;'>
				<br>
				<img alt='G4' height='332' src='Site/images/fullg4.png' width='333'></p>
				<span class='style144' style='box-sizing: border-box; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-size: xx-large; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				</span>
				</div><hr>
				<h3 class='center'>Manufacturing G Series at Insight</h3>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; color: rgb(27, 53, 81); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<span class='Apple-converted-space'>&nbsp;			
				<span class='style144' style='font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-size: xx-large; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				<span class='style129' style='font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: Arial, Helvetica, sans-serif; line-height: normal; border-collapse: separate; color: rgb(0, 0, 0); orphans: 2; widows: 2; border-spacing: 0px; -webkit-text-decorations-in-effect: none; font-size: medium;'>
				<iframe id='I1' allowfullscreen='' frameborder='0' height='315' name='I1' src='' width='560'>
				</iframe></span></span></span>&nbsp;</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; color: rgb(27, 53, 81); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<iframe width='560' height='315' src='' frameborder='0' allow='autoplay; encrypted-media' allowfullscreen>
				</iframe>&nbsp;</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; color: rgb(27, 53, 81); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G4' height='340' src='Site/images/3.125.png' width='275'></p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G4' height='284' src='Site/images/g4size.png' width='600'></p>
				<div>
					<p>Insight's 610C Graphic Engine Monitor (G3) color-coded bargraph 
				and digital values may be Primary for CHT, EGT and TIT.<br>All 
				other data shown in cyan at the top of display are to be 
				supplementary.</p>
					<p>Traditional multi-cylinder exhaust gas and cylinder head 
					temperature systems that force the pilot to switch or scan 
					an indicator from cylinder to cylinder in search of critical 
					engine data, are long obsolete. Using the latest computer 
					technology, the G3 presents a clear, concise, graphic 
					picture of all engine temperatures simultaneously for 
					interpretation at a glance.</p>
					<p>Never before has so much engine diagnostic information been 
					available to the pilot and never before, has the pilot been 
					able to control mixture with such ease and precision for 
					peak fuel efficiency.</p>
					<p>Insight's latest G4 automatically records flight temperature 
					and will also interface with other data sources and report 
					information to other instruments like MFD’s. The data-log 
					files stored on the SD card can be easily retrieved by the 
					pilot, in-flight or post-flight, for instant viewing or 
					permanent record-keeping.</p>
					<p>The G4 is a sophisticated tool for engine management. Its 
					microprocessor performs many tasks that used to be handled 
					by the pilot. One of the basic functions performed by the G4 
					is monitoring exhaust gas temperatures for all cylinders 
					with one degree resolution. What is important is the exhaust 
					gas temperature of a particular cylinder in relation to its 
					peak. But peak EGT is not a constant; it changes with 
					atmospheric conditions, altitude, power setting and engine 
					condition and for this reason absolute exhaust gas 
					temperatures in degrees Fahrenheit are quite meaningless.</p>
					<p>The real objective of mixture management is finding a 
					mixture setting which represents the correct position on the 
					EGT/Fuel Flow Curve. As we will see later, this abstract 
					task is easily accomplished by the G4's microprocessor which 
					samples EGT's for all cylinders many times a second and 
					subjects this data to a complex mathematical analysis can 
					identify peak. This capability allows the pilot to operate 
					his or her aircraft engine at the most economical mixture 
					settings.<br></p>
					<p>It is generally known that EGT can be a valuable source of 
					information for engine diagnosis and troubleshooting, but 
					there is a great deal of confusion when it comes to 
					interpreting this data. One of the basic principles of EGT 
					engine analysis is that engine temperatures (EGT and CHT) 
					achieve equilibrium in an engine operating at a constant 
					power and mixture setting. What is often overlooked is that 
					this equilibrium cannot be defined as a single point but 
					rather a range of temperatures.<br></p>
					<p>The Graphic Engine Monitor (G4) is ready to operate the 
					moment electrical power is applied. Within seconds after 
					starting the engine, the white EGT bar graph columns will 
					begin to appear on the G4 display. Each column corresponds 
					to the Exhaust Gas Temperature (EGT) of a cylinder. The 
					lowest exhaust gas temperature that can be displayed by the 
					G4 is 800° F. In some engines, the throttle will have to be 
					opened to the fast idle range to get an EGT indication for 
					all cylinders. As the cylinder heads begin to warm up, the 
					display will indicate Cylinder Head Temperature (CHT) for 
					all cylinders as a smaller green bar in each EGT column. A 
					horizontal red line across each column represents the 
					maximum allowable CHT. Digital numbers below each bar graph 
					column indicates the exact EGT and CHT for each cylinder.<br>
					</p>
					<h3>G4 Twin Buss Voltage</h3>
					<p>The G4 Buss Voltage attempts to display the buss voltage in 
					green when it’s normal and red when it’s outside of normal. 
					In an aircraft with a 12V electrical system the Buss Voltage 
					will be annunciated in green so long as the voltage is 12.0V 
					to 14.9V (inclusive).In an aircraft with a 24V electrical 
					system the Buss Voltage will be annunciated in green so long 
					as the voltage is 24.2V to 28.7V (inclusive). Below this 
					range the alternator isn’t charging the battery and above 
					that it’s overcharging, and the Buss Voltage will be 
					annunciated in red. The instrument must be connected to the 
					main voltage buss (not in series with something else, on a 
					lighting buss, etc.) and must have a good low-resistance 
					ground connection, otherwise the voltage measurement itself 
					will be in error causing the Buss Voltage to indicate in red 
					erroneously.</p>
					<h3>Controlling the G4 instrument</h3>
					<p>
					The instrument has two 
					control knobs that operate combination rotary and push 
					button switches. The PG knob in general controls screen 
					selection while the SEL knob controls items within the 
					given screen. Each screen assigns its own functional needs 
					to the controls that may change depending on context. A 
					screen may also label the controls with guidance information 
					like “Push to exit”.</p>
					<p>The Bar-Graph Display Screen<br>
					<br>The Exhaust Gas 
					Temperature is displayed in white bar graph form and is 
					interpreted much like a conventional mercury thermometer. 
					The higher the bar, the higher the temperature.<br></p>
					<p>The cylinder head temperature is displayed in green single 
					bar format. During normal operation it shows as a green 
					illuminated bar in the lower half of the bar column. Since 
					EGT is normally higher than CHT, the green bar which 
					represents CHT is on top of the white illuminated EGT bar 
					and stands out clearly. However, when the engine is 
					shutdown, the EGT quickly drops to zero and the cylinders 
					remain warm for sometime.<br></p>
					<p>The G4 provides a reliable indication of cylinder head 
					temperature even with the engine shut down. Should an EGT 
					probe fail, the entire EGT column for that cylinder will go 
					blank, and the numeric indication will show --- that is 
					dashes, but the CHT bar will still remain green. The failure 
					of one probe will not affect the display of any other probe.<br>
					</p>
				</div>
				<hr>
				<div><h3>AVWeb Insider -<span class='Apple-converted-space'>&nbsp;</span><a href='' style='color: rgb(51, 51, 51); text-decoration: underline;'>New 
				Insight Engine Monitor and So Much More</a>
				</h3>
				<p><em>By Rick Lindstrom</em><br>
				<br>
				Insight, the originator of the Graphic Engine Monitor, surprised 
				everyone by unveiling a new third generation GEM called<b><span class='Apple-converted-space'>&nbsp;</span>G3</b><span class='Apple-converted-space'>&nbsp;</span>at 
				Sun n Fun. By no means a luke warm sequel the<span class='Apple-converted-space'>&nbsp;</span><b>G3</b><span class='Apple-converted-space'>&nbsp;</span>is 
				a breakthrough product.Featuring a bright full color display it offers numerous screens 
				of new functionality previously unavailable anywhere. While the original lean screen is gone a vastly improved screen 
				replaces it with special functionality for lean of peak 
				operation. G3 logs data to readily available SD digital camera cards. A low 
				cost card will store decades of flight data. The new<span class='Apple-converted-space'>&nbsp;</span><b>G3</b><span class='Apple-converted-space'>&nbsp;</span>writes 
				PC compatible files and directories so no special software is 
				required to process or transfer data. Its extensive data log 
				files include flight data from Insight’s TAS-1000 air data 
				system and nav info from your GPS. Despite its enormous capabilities the new is a compact size and plug-compatible replacement for all previous 
				GEMs. Insight offers a generous GEM trade-in to make upgrades 
				easy.</p>
				</div>
				<hr>
				<h3>Restarting The Leaning Process</h3>
					<p>Restart the leaning 
				process and resetting the peak indications on G1 by short push 
				of bottom button.<br>Restart the leaning process and resetting 
				the peak indications on G2/3/4 single by a short push of the SEL 
				button.<br>Holding the SEL knob for about 3 seconds on G4 twin 
				will take you back to twin-engine screen.</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img class='responsive' alt='Chart' src='New%20Images/function%20chart.jpg' width='830'></p>
				<hr>
				<div>
				<H3>
				<img alt='G4' height='244' src='Site/images/g4sprobe.png' style='float: right' width='256' class='auto-style40'>Probe Screen</h3>
				<p>The 
				Need for better Diagnostic Tools</p>
				<p>Even the first GEM could detect an open probe and blank its 
				indication. Over the years by helping owners and their mechanics 
				trouble shoot instrument problems I developed a new 
				understanding and sympathy for the challenge they faced.</p>
				<p>Troubleshooting avionics is an expensive and time-consuming 
				process. Often times the procedure requires access to the 
				instrument connector for continuity measurements. This might 
				take hours of instrument panel disassembly just to touch the 
				connector. We needed something better, easier to use, less time 
				consuming and therefore less expensive.</p>
				<p>Why not have the instrument diagnose itself? Then you don’t have 
				to disassemble the airplane or even touch the wiring. This is 
				not as easy as it might seem. Adding resistance measurement 
				hardware for each and every probe wire would more than double 
				the complexity of the measurement system. I considered this 
				carefully during the development of the GEM-610 second 
				generation instrument. It would at least add a second PC board 
				to the instrument and have even greater adverse impact on the 
				GEMINI twin version. Even if we endured these problems to get 
				the information we had no practical way to display it on an 
				orange bar display.</p>
				<p>So I abandoned it then, but revisited again this time. The new 
				color display was certainly adept at displaying the information, 
				eliminating that problem, but the resistance data was still hard 
				to get.</p>
				<p>So this time I was able to invent a new way of measuring 
				resistance. The simple idea worked beautifully without adverse 
				impact on the design. It was so simple in fact even I was 
				skeptical at first.</p>
				<p>Without this simple breakthrough we’d still be diagnosing things 
				the hard way.</p>								
								<h4>So what does the diagnostic system do?</h4>
								<p>The probe diagnosis page indications are in 
								green for normal readings and red for readings 
								that fail the criteria set at the bottom of the 
								screen.<span class='Apple-converted-space'>&nbsp;</span><br>
								Each temperature probe consists of two wires, a 
								positive lead and a negative lead. The two 
								numbers next to each identifier show the 
								resistance in Ohms of each lead.<span class='Apple-converted-space'>&nbsp;</span><br>
								For example, the line EGT1 8 3 means the 
								positive lead of the EGT1 probe has 8 Ohms 
								resistance, and the negative lead has 3 Ohms 
								resistance.<br>When the probe is new, it will have relatively 
								low resistance.<span class='Apple-converted-space'>&nbsp;</span><br>
								As the probe ages, it’s resistance will slowly 
								go up. Eventually, the probe will measure 
								outside the pas/fail criteria you set at the 
								bottom of the screen, and change from green to 
								red, indicating that the probe should be 
								replaced before it fails and leaves you with no 
								temperature reading at all.</p>
					<span class='Apple-converted-space'>&nbsp;</span>&nbsp;<p class='style125' style='padding: 5px; margin: 0px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
								<img alt='G3' height='220' src='Site/images/G3_probe2.jpg' style='border: 0px; max-width: 100%;' width='474'><br>
								</p>
								<p>One other point to consider is that the longer 
								the wiring to the probes, the higher its 
								resistance.<span class='Apple-converted-space'>&nbsp;</span><br>
								Every foot of EGT wire adds 1.7 Ohms/ft for the 
								+ lead and 0.8 Ohms/ft for the - lead. Every 
								foot of CHT wire adds 0.8 Ohms/ft for the + lead 
								and 1.2 Ohms/ft for the - lead.<span class='Apple-converted-space'>&nbsp;</span><br>
								A 24 ft harness will fail the criteria that an 8 
								ft harness will pass with. That is why we allow 
								the user to modify the pass/fail criteria on the 
								bottom of the screen.<br>The meaning of the 
								pass/fail criteria is as follows:<br>R MAX sets the maximum resistance (in Ohms) that 
								any single lead may have. If the R MAX is set to 
								20 Ohms a probe with either the positive or 
								negative leads measuring greater than 20 Ohms 
								will be annunciated in RED, otherwise its 
								displayed in GREEN.<br>R DIF sets the maximum resistance (in Ohms) that 
								the positive lead may differ from the negative 
								lead. If R DIF is set to 10 Ohms, the positive 
								and negative leads need to measure within 10 
								Ohms of each other to be annunciated in GREEN, 
								otherwise its RED</p>
								<hr>
								<h2>EGT Variation Screen -	
					<a href='eva.htm'>View Mag Ad.</a>
					</h2>
							</div>
							<h3>This is a new form of engine analysis.</h3>
				<p>Some valve related engine faults produce a slow periodic 
				variation in EGT. The oscillation rate is on the order of one cycle every minute 
				or two. This is just too slow to be identified by occasional 
				observation of the temperatures alone. Yet it is very important 
				to discover this phenomenon because it may lead to a 
				catastrophic engine failure. It readily appears in a slow 
				sampled spectrum analysis.&nbsp;<br><br>Temperature samples are collected once per second for each 
				cylinder and analyzed each second. The entire sample interval is 
				about 8 minutes. A normal indication will be a flat line with a 
				little noise, while a trouble indication will show as an obvious 
				spectral peak.</p>
				<p style='padding: 5px; margin: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G4' height='244' src='Site/images/egtvariation1.png' width='256'><img alt='G4' height='245' src='Site/images/egtvariation2.png' width='256'></p>
				<hr>
				<h2>Vibration Screen</h2>
				<h3>New Capabilities for the Next Generation G4 GEM</h3>
				<p>If you take a step back from the EGT/CHT idea to explore engine 
				monitoring in general, you discover that at least half the 
				engine monitoring solution is missing. EGT analysis reveals 
				combustion phenomenon but simply ignores mechanical problems.</p>
				<p>By the time a mechanical problem shows up in EGT, if it ever 
				does, the damage is done and it is far too late to do anything 
				about it.</p>
				<p>Vibration analysis is the key to pre-emptive detection of 
				mechanical problems.</p>
				<p>
				<span lang='EN-US'>Following the update of the G</span>4<span lang='EN-US'> Graphic Engine 
				Monitor to V1.78 or higher, the Vibration Analysis screen will 
				now appear among the supplementary screens when the PG knob is 
				turned. In order for the vibration analysis to function your G</span>4<span lang='EN-US'> 
				must be equipped with a vibration sensor and a connection to the 
				magneto for RPM measurement.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>If 
				your instrument was purchased prior to September 2011, Insight 
				will be sending you a vibration sensor shortly.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>Instruments 
				purchased after this date will ship with the sensor included 
				with the main kit.</span></p>
				<p>
				<span lang='EN-US'>After the electrical connections to the 
				sensor are made, then sensor may be tested simply by powering up 
				the G</span>4<span lang='EN-US'> and vibration sensor. It is not necessary to start the 
				engine to perform this test. The sensor LED should flash briefly 
				and rapidly when power is first applied until communication is 
				established with the G</span>4<span lang='EN-US'>, at which time the LED blinks more 
				slowly (approximately once per second). When the LED indicates 
				communications with the G</span>4<span lang='EN-US'> has been established select the 
				Vibration Analysis screen by turning the PG knob. While 
				observing the vibration graph disregard the “RPM Required” 
				message and rap lightly on the vibration sensor with the handle 
				of a screw driver. The graph should register the impacts.</span></p>
				<p>
				<span lang='EN-US'>The sensor should then be firmly mounted 
				directly to the engine case, preferably oriented in such a 
				manner as to match the small airplane symbol engraved on the 
				sensor body. In some rare cases it may not be possible to mount 
				it in this manner, and the installer will have to fabricate an 
				appropriate bracket or else be prepared to compensate for the 
				change in orientation when viewing the vibration data. A 
				representative installation is shown in the following figure:</span></p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='Sensor' class='style131' height='240' src='Site/images/vib-sensor4.jpg' style='border: 1px solid; max-width: 100%;' width='360'></p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<h4>Using the Vibration Analysis Screen on the G4:</h4>
				<p>
				<span lang='EN-US'>The sensor detects vibration in all 3 axis 
				(fore-aft labeled x, up-down labeled z, and left-right labeled 
				y) which are presented on different sub-screens. The vibration 
				analysis only functions when the engine is running and a valid 
				rpm signal is detected.</span></p>
				<p>
				<span lang='EN-US'>In regards to the vibration graph, the 
				vertical axis represents the amount of vibration energy and the 
				horizontal axis represents the frequency spectrum expressed as 
				multiples of crankshaft rpm. When the engine is running, the 
				screen will come alive with a waveform that represents the 
				engine motion, presented in a spectral format with the 
				crankshaft energies appearing at the 1x mark on the bottom 
				scale. Propeller vibration will likewise be synchronous with the 
				crankshaft vibration. Other sources of vibration will tend to 
				produce energies at other frequencies.</span></p>
				<p>
				<span lang='EN-US'>For example, camshaft vibration tends to 
				accumulate at the .5x mark, since the cam turns at 1/2 the rate 
				of the crankshaft. Magneto vibration will appear at 1.5x mark in 
				a 6-cylinder engine. Alternator vibration may appear somewhere 
				around 3x or 4x, depending on the ratio it is driven at.</span></p>
				<p>
				<span lang='EN-US'>A gear-driven alternator may appear in a 
				different axis than the crankshaft does<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>if 
				it is mounted at 90deg to the engine, although ANY source of 
				vibration will show some energy in all three axis. Complex 
				vibration as generated by reciprocating machinery will also 
				produce a great number of harmonic spikes, which at first glance 
				may seem confusing. The user should experiment with running the 
				engine at different power settings under different conditions to 
				get a feel for what is a 'normal' spectrum for their particular 
				engine.<span class='Apple-converted-space'>&nbsp;</span><span>&nbsp;</span>A 
				simplified case of vibration is shown in the following figure:</span></p>
				<p class='MsoNormal' style='padding: 5px; margin: 0px; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G4' height='245' src='Site/images/g4twinvibration.png' width='249'></p>
				<p class='style130' style='padding: 5px; margin: 0px; text-align: center; color: rgb(0, 0, 0); font-family: Arial, Helvetica, sans-serif; font-size: small; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				&nbsp;</p>
				<p>
				<span lang='EN-US'>In the example shown above the main source of 
				energy is at the 1x mark, and represents the crankshaft rpm. The 
				smaller spikes at the 0.5x mark and the 1.5x point are probably 
				created by the camshaft and the magneto, respectively. The user 
				should be aware that a multi-cylinder reciprocating engine 
				produces energies at a multitude of frequencies and directions, 
				which reinforce and subtract from each other to create a very 
				complex waveform. It is the responsibility of the user to gain 
				familiarity with a waveform that is typical of their particular 
				engine, so that unusual readings can be detected and 
				interpreted.</span></p>
				<p>The user may examine the various sub-screens 
				by pushing the top button (PG). There are presently six screens 
				to examine, each of the primary axis (X,Y and Z) and an averaged 
				version of each (denoted Ax, Ay, and Az). The averaged version 
				will be much 'cleaner' and contain less noise than the raw 
				measurement and is the preferred screen to examine for each 
				axis. The bottom knob (SEL) controls a cursor which will 'snap' 
				to nearby vibration spikes to make it easy to examine them 
				closer. The bottom knob can also be pushed to enter a zoom mode. 
				When in zoom mode, turning the bottom knob will allow you to 
				scroll through the waveform. Continue to press the bottom knob 
				to set progressively higher zoom modes. A further press when at 
				maximum zoom will return you to the overall view.</p>				
				<p>
				<span lang='EN-US'>Pressing and holding the PG button will 
				trigger the G</span>4<span lang='EN-US'> to save the present vibration waveform for future 
				reference. The waveform will be stored as a series of 
				hexadecimal bytes in the current log file. Insight can provide a 
				tool for examining this waveform using Excel or a similar 
				spreadsheet. The tool is presently in the earliest functional 
				stages of development, and will be improved over time.</span></p>
				<p>
				<span lang='EN-US'>It is expected that the vibration functions 
				will be used as a 'condition-monitoring tool'. Since every 
				engine and accessory combination is different, everyone's 
				vibration spectrum will look unique and it would be impossible 
				to generalize the interpretation of the spectrum. The user will 
				come to recognize what a 'normal' spectrum looks like for their 
				engine and by periodically scanning the vibration screen can 
				recognize when potential trouble is developing. When a new spike 
				appears or an existing spike begins to show signs of higher than 
				normal amplitude further investigation is warranted. The source 
				of the spike can be interpreted by noting its primary axis and 
				its frequency relative to crankshaft RPM as discussed above. By 
				periodically saving their vibration data as discussed above, the 
				user can create a database of reference waveforms for future 
				comparison.</span></p>
				<hr>
				<p><em>While in-flight with the vibration screen showing on G4,
				Pressing and holding the PG button will trigger the G4 to save 
				the present vibration waveform for future reference.</em></p>
				<div class='center' style='color:red'>
					<strong>Hold PG button in until G4 screen says it is data logging vibration data.
					</strong>
				<span class='style144' style='font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-size: xx-large; font-family: Arial, Helvetica, sans-serif; line-height: normal; orphans: 2; widows: 2; border-collapse: separate; color: rgb(0, 0, 0); border-spacing: 0px; -webkit-text-decorations-in-effect: none;'><span class='style126' style='font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: Arial, Helvetica, sans-serif; color: rgb(0, 0, 0); line-height: normal; orphans: 2; widows: 2; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'><span class='style149' style='color: rgb(0, 0, 0); font-size: small; font-family: Arial, Helvetica, sans-serif; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				</span></span></span></div>
				<hr>
				<h3>
				<strong style='font-weight: bold !important;'>Take Off G Force 
				Screen</strong></h3>
				<font class='style158' size='1' style='font-size: small;'>
				<span class='style149' style='color: rgb(0, 0, 0); font-size: small; font-family: Arial, Helvetica, sans-serif; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='Take-off' height='245' src='Site/images/takeoff.png' width='258'></p>
				<hr></span></font>
				<h3>
				<strong style='font-weight: bold !important;'>Turbulence Display 
				Screen</strong></h3>
				<h1 class='text-center' style='color: rgb(0, 0, 0); margin: 0px; padding: 0px; font-weight: normal; font-size: 11px; letter-spacing: normal; text-align: center; font-family: Verdana, Arial, Helvetica, sans-serif; text-shadow: rgba(0, 0, 0, 0.0980392) 1px 1px 1px; font-style: normal; font-variant: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<img alt='G4' height='245' src='Site/images/turbulence.png' width='256'></h1>
				<h1 class='style126' style='color: rgb(0, 0, 0); margin: 0px; padding: 0px; font-weight: normal; font-size: small; letter-spacing: normal; font-family: Arial, Helvetica, sans-serif; text-shadow: rgba(0, 0, 0, 0.0980392) 1px 1px 1px; text-align: left; font-style: normal; font-variant: normal; line-height: normal; orphans: 2; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				&nbsp;</h1>
				<p>The G3-4 contains a 3-axis accelerometer sampled at modest rates 
				to measure turbulence and landing shock.</p>
				<p>Knowledge of G forces will help the pilot to operate the 
				airplane safely by slowing to maneuvering speed. Landing shock 
				is a good training aid for smooth landings and a predictor of 
				structural damage.</p>
				<p>Data logged G force will report unauthorized aerobatic activity 
				or abuse of rental aircraft. It could also be useful in accident 
				investigation.</p>
				<span class='style126' style='font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; word-spacing: 0px; -webkit-text-stroke-width: 0px; font-family: Arial, Helvetica, sans-serif; font-size: small; color: rgb(0, 0, 0); line-height: normal; orphans: 2; widows: 2; border-collapse: separate; border-spacing: 0px; -webkit-text-decorations-in-effect: none;'>
				</span>
				<hr style='color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<h3>Measuring Horse Power Screen</h3>
				<p>
				<img alt='G4' height='244' src='Site/images/g4shp.png' style='float: right' width='256'>On 
				a test stand engine horsepower is derived by measuring the 
				twisting force (torque) that the engine exerts on a load.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>In 
				fact horsepower is defined as simply the product of torque times 
				RPM.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>Therefore 
				if our piston engines were equipped with real torque transducers 
				we could utilize RPM and compute real horsepower. While such 
				torque transducers are commonly used to calibrate turbo-prop 
				engines they actually cost more than a typical piston engine. 
				Sadly there is no practical way to directly measure horsepower 
				in a piston aircraft engine.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>But 
				this hasn’t stopped at least one engine instrument manufacturer 
				from making bogus claims to the contrary!<o:p></o:p></p>
				<p>REMEMBER: There&nbsp;is&nbsp;no 
				practical way to truly measure horsepower.</p>
				<span class='style125' style='font-family: Arial, Helvetica, sans-serif; border-collapse: collapse; color: rgb(27, 53, 81); font-size: 12px; text-align: left;'><span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'><span class='style125' style='font-family: Arial, Helvetica, sans-serif; border-collapse: collapse; color: rgb(27, 53, 81); text-align: left;'><span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px;'></span></span></span></span>
				<p>If 
				you planned to use your horsepower display to gauge take off 
				performance or measure engine health you can forget it. In fact, 
				dynamometer tests of so-called horsepower displays revealed NO 
				CHANGE in indicated “horsepower” even when individual cylinders 
				were completely disabled!</p>
				<h3>The Insight Approach to Power</h3>
				<p>Despite some limitations we elected to put a power display in 
				the G4 graphic engine monitor. To 
				prevent any misconceptions we called it “Theoretical 
				Horsepower”, and under certain conditions it actually does a 
				pretty good job of reporting horsepower. One dependable metric 
				of power is fuel consumption. At peak EGT and leaner where ample 
				or excess oxygen available to consume the available fuel 
				horsepower is a linear function of fuel flow. At richer mixtures 
				where some fuel remains unconsumed and doesn’t contribute its 
				full power potential the simple linear relationship falls apart. 
				Prior to leaning to peak the display is challenged to deliver an 
				accurate horsepower display but once peak has been reached the 
				rich-of-peak accuracy will improve.</p>
				<p>One limitation of the fuel method is that it is not sensitive to 
				engine faults that can significantly affect the power produced. 
				For example, a cylinder without ignition won’t combust the fuel 
				to produce power, but will nevertheless continue to consume it. 
				So don’t expect to diagnose engine performance issues with the 
				fuel flow approach to horsepower calculation.<o:p></o:p></p>
				<p>What good is a fuel flow based horsepower calculator? The 
				intended purpose of the theoretical horsepower display is to 
				provide an indication of power for leaning purposes. For 
				example, lean-of-peak operation is not recommended at power 
				settings greater than 65%.<span>&nbsp;<span class='Apple-converted-space'>&nbsp;</span></span>It 
				is interesting to see the reduction in horsepower that 
				accompanies lean of peak operation.</p>
				<h3>The Insight Approach to Performance Measuring</h3>
				<p>While the G4	does not directly measure true horsepower 
						(remember that no engine monitor does) it does measure 
						the EFFECT of horsepower on takeoff acceleration. This 
						information is displayed on the “Take Off Performance” 
						screen and recorded in the log file too. Acceleration is 
						direct function of engine thrust and other factors like 
						weight, runway conditions, slope and even tire pressure. 
						Of course, ambient conditions like altitude and 
						temperature will affect engine power and therefore take 
						off performance.</p>
						<hr>
				<h2>Insight announces the next big breakthrough in engine 
				monitoring</h2>
				<div class='text-right' style='text-align: right;'>
					<p class='text-center' style='text-align: center; padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-weight: bold; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					<img alt='G4' height='245' src='Site/images/interface.png' width='253'></p>
					<span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'>
					</span></div>
				<p>In<span class='Apple-converted-space'>&nbsp;</span>G 
					Series Software<span class='Apple-converted-space'>&nbsp;</span>Version 
					208<span class='Apple-converted-space'>&nbsp;</span>the 
					G3-4<span class='Apple-converted-space'>&nbsp;</span>has 
					a new page that displays data received from the TAS-1000.</p>
				<p>
				The GEM's data-logging capabilities can be extended by 
					receiving air data from a TAS-1000 air data computer. This 
					page shows real-time air data which includes True Airspeed, 
					Pressure Altitude, and Wind Speed and Wind Direction all of 
					which are recorded in the GEM's data log along with engine 
					and fuel data.</p>
				<div align='left'>
					<p class='style126' style='padding: 5px; margin: 0px; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					<span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'>
					<img alt='TAS-GPS' height='282' src='Site/images/g3%20tas%20gps2.png' style='border: 0px; max-width: 100%;' width='425'></span></p>
					<p class='style126' style='padding: 5px; margin: 0px; text-align: center; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					&nbsp;</p>
					<p>Insight’s G3-4 is now capable of receiving RS-232 serial 
					data from our TAS-1000 MFDS that includes Indicated Air 
					Speed, True Air Speed, Pressure Altitude, True Air 
					Temperature, Wind Direction, Wind Speed, and Heading in the 
					data log file on every flight.</p>
					<p>While the detail in the G3-4 data log is unprecedented – now 
					it is even better.</p>
					<p>The G4 engine log system has been transformed to a complete 
					aircraft performance logging system.</p>
					<p>Now you can log aircraft performance data right along with 
					your engine data.</p>
					<p>The missing link in data log analysis is finally available.</p>
					<p>Now you can really tell what’s happening. Much of the 
					black-box functionality previously available only in Jets is 
					now available to you.</p>
					<p>The key to operating your aircraft efficiently is 
					understanding its performance. Now every data log is like a 
					performance chart from the flight manual but it is specific 
					to your aircraft and actual conditions.</p>
					<p>Don’t forget about the Insight TAS 1000’s ability to fill in 
					your GPS pages with real-time air data, fuel, wind data page 
					and also with wind arrow and wind speed on your moving map.</p>
					<span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'>
					</span>
					<span class='Apple-style-span' style='border-collapse: separate; color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: normal; orphans: 2; text-align: -webkit-auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; border-spacing: 0px; -webkit-text-decorations-in-effect: none; -webkit-text-stroke-width: 0px; font-size: medium;'>
					</span></div>
				<p>
				With no TAS the G3-4<span class='Apple-converted-space'>&nbsp;</span>displays 
				only OAT (Outside Air Temperature) but&nbsp;with 
				a TAS-1000<span class='style129' lang='EN-US' style='font-family: Arial, Helvetica, sans-serif; font-size: small;'><span class='Apple-converted-space'>&nbsp;</span></span>the 
				missing link in data log analysis is finally available.<br>
				</p>
				<p class='style126' style='padding: 5px; margin: 0px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-align: center; color: rgb(0, 0, 0); font-family: 'Trebuchet MS', Arial, Helvetica, sans-serif; font-size: 12px; line-height: normal; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='TAS-1000' height='145' src='Site/images/tas1000.png' style='border: 0px; max-width: 100%;' width='230'></p>
				<p>With the TAS installed in addition to OAT the G3-4&nbsp;displays 
				also displays</p>
					<ul>
					<li>TAT (Total Air Temperature)</li>
					<li>IAS (Indicated Air Speed)</li>
					<li>TAS (True Air Speed)</li>
					<li>ALT (Pressure Altitude)</li>
					<li>WD (Wind Direction)</li>
					<li>WS (Wind Speed)</li>
					<li>HDG (Heading)</li>
				</ul>
				<hr style='color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<div>
				<h2>Turbulence and Hard Landings:</h2>
				&nbsp;Now 
				we go back in time to capture a turbulent transient or a landing 
				event.&nbsp;In the miscellaneous configuration screen the 
				pilot can now set the threshold for the vertical axis G-force. Every time this threshold is exceeded the 
				G3/G4 records a 12 second interval of the turbulence in the log 
				file. <br>These twelve seconds consist of data from 
				the 6 seconds before the event and the 6 seconds after it.<br>There are two new screens between Two Axis 
				Turbulence and Takeoff G-force which display live G-force and a 
				snapshot of the G-Force from last event (threshold exceeded).
					<br>The user can view a graph of the last 12 seconds 
				of live data or view the last captured event.
					This feature will also capture hard landings. The graph is automatically scaled for maximum 
				zoom based on threshold.&nbsp;&nbsp;When 
				the threshold is exceeded the 12 second G-force is also recorded 
				in the log file.The new transient G-force screen shows you the whole 
					event the moment it happens. You won’t miss a thing.&nbsp;<br>The event is also marked and stored in the log file for 
					easy reference later.&nbsp;<br>The pilot can set the trigger threshold on the G-force 
					screen for normal operation. Just prior to landing the 
					instrument automatically resets that threshold to always 
					capture the landing event. Just 6 seconds after touch down a 
					high resolution picture of the landing is available.&nbsp;<br>
					<br>It is all automatic, and couldn’t be easier.&nbsp;<br>
					<br>This new feature is available on all new G3 &amp; G4 
					instruments and is available at no charge to all current 
					customers in the latest update.&nbsp;<br>
					<br>Just download and update your instrument from our website.&nbsp;</div>
				<p class='text-center' style='text-align: center; padding: 5px; margin: 10px; color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G4' height='246' src='Site/images/dynamic.png' style='border: 0px; max-width: 100%;' width='246'>&nbsp;<span class='Apple-converted-space'>&nbsp;</span><img alt='G4' height='238' src='Site/images/g4snapshot.png' style='border: 0px; max-width: 100%;' width='239'></p>
				<h2>User Configuration</h2>
				<p class='auto-style6' style='text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: x-large; padding: 5px; margin: 10px; color: rgb(85, 85, 85); font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
				<img alt='G4' height='245' src='Site/images/user.png' width='257'></p>
				<p>Using the knobs to 
							navigate the G3-4:<br><br>The G3-4 has two knobs: PD 
							select page and SEL work within page. There are two 
							functions built into each knob; the push button 
							switch activated by pressing the knob in, and the 
							selection is activated by turning the knob either 
							clockwise or counter clockwise.<br><br>The PG knob 
							is used to select the various screens. From the main 
							temperature bargraph screen turn the PG knob counter 
							clockwise 2 clicks to get to the User Configuration 
							screen. Once you are there you do not use the PG 
							knob any more because turning it takes you away from 
							the User Configuration screen.<br><br>The SEL button 
							is pressed to select a line for adjustment. When you 
							first enter a screen by default no line is selected. 
							Pressing the SEL button once selects line 1. The 
							selected line is shown in yellow. Pressing it a 
							second time selects line 2. On any line with 
							multiple selections the selected item will be shown 
							in red.<br><br>Setting up the G3 Temperature 
							Bargraph Display:<br><br>On the User Configuration 
							screen there are some options for setting up the 
							temperature bargraph display. There are three 
							different ways to accomplish this. One method is to 
							use the Auto range function to configure the display 
							for you. <br>Another method is to adjust the MAX EGT 
							TEMPERATURE and AUTORANGE INFLECTION parameters 
							manually, and a third method is to set the bar 
							heights visually on the main screen.<br><br>On line 
							2 (EGT AUTORANGE) there are 3 possibilities ON OFF 
							and SAVE. After pushing the SEL button until this 
							line is highlighted in yellow, the SEL knob may then 
							be turned to make a selection on this line. When on 
							line 2 turning the SEL knob fully counter clockwise 
							selects nothing. From there turning the SEL knob one 
							click clockwise selects ON. The current selection is 
							shown in red. Turning the SEL knob another click 
							clockwise selects OFF. And one more turn clockwise 
							selects SAVE.<br><br>Using the Auto Range function 
							(Method 1):<br><br>To turn OFF the auto range 
							capability on the User configuration screen:<br><br>Press the SEL button twice to select line 2 (EGT 
							AUTORANGE).<br>Turn the SEL knob to select OFF on 
							line 2.<br>Press the SEL button to select line 7 
							“SAVE CONFIG”<br>Turn the SEL knob to select YES on 
							line 7.<br>Press the SEL knob to save the choice.<br>We have now turned off auto ranging.<br>
				<br>To turn 
							ON the auto range capability on the User 
							configuration screen:<br>Press the SEL button to 
							select line 2. (EGT AUTORANGE).<br>Turn the SEL knob 
							to select ON on line 2.<br>Press the SEL button to 
							select line 7 “SAVE CONFIG”<br>Turn the SEL knob to 
							select YES on line 7.<br>Press the SEL knob to save 
							the choice.<br>We have now turned on auto ranging.<br>
				<br>In order to use the 
							auto range function it must be turned on as 
							described above. Once this function is enabled, the 
							G3-4 will automatically adjust the EGT MAX 
							TEMPERATURE and AUTORANGE INFLECTION to be 
							appropriate for the highest temperature reported by 
							the probes. <br>You should now take the airplane and 
							perform a typical flight. <br>The G3-4 will analyze 
							the EGT temperatures and scale the temperature bars 
							as required so that the entire temperature range 
							measured by the EGT probes is displayed on the main 
							bargraph screen. <br>It is important to realize that 
							so far this adjustment is temporary. If we want it 
							to remain permanent we must return to the User 
							Configuration screen.
							<br>
							<h4>To save the results of auto ranging:</h4>
							<ul>
					<li>Press the SEL button to select line 2 (EGT AUTORANGE).</li>
					<li>Turn the SEL knob to select SAVE on line 2.</li>
					<li>Press the SEL button to	select line 7 “SAVE CONFIG”</li>
					<li>Turn the SEL knob to select YES on line 7.</li>
					<li>Press the SEL knob to save the choice.</li>
					<li>The results are saved, and auto ranging is turned OFF.</li>
				</ul>
				<p>The main temperature 
							bargraphs should now be scaled properly for this 
							individual airplane on all subsequent flights.<br>Auto ranging may be turned on and the range 
							relearned as often as desired.<br></p>
				<h4>Setting up the 
							G3 Temperature Bargraph display manually (Method 2):</h4>
				<p>In some cases it may be desirable to set or 
							refine the temperature bargraph screen manually. <br>To do so, return to the User Configuration screen 
							and make sure EGT AUTORANGE is turned OFF as 
							described earlier. Adjust EGT MAX TEMPERATURE and 
							AUTORANGE INFLECTION directly by using the following 
							procedure:<br>To set an EGT MAX TEMPERATURE and AUTORANGE 
							INFLECTION on the User configuration screen:<br>Press the SEL button to select line 3 (AUTORANGE 
							INFLECTION) or line 4 (EGT MAX TEMPERATURE).<br>Turn 
							the SEL knob to select a value as desired. Notice 
							that adjusting the AUTORANGE INFLECTION affects the 
							value of EGT MAX TEMPERATURE and vice versa.<br>Press the SEL button to select line 7 “Save Config”<br>Turn the SEL knob to select YES on line 7.<br>Press 
							the SEL knob to save the choice.</p>
				<h4>AUTORANGE INFLECTION and EGT MAX TEMPERATURE explained:</h4>
				<p>The Autorange Inflection point is the point 
							along the temperature graph at which the scale of 
							the bars change. <br>Below the inflection point (ie, 
							at low temperatures) readings are displayed with a 
							coarse resolution (the bars go up/down a small 
							amount for a relatively large change in 
							temperature). <br>Above the Inflection Point (at 
							higher temperatures than the Inflection Point) the 
							bars are displayed in a higher resolution (the bars 
							go up/down more for a small change in temperature).
							<br>The net effect is that the dynamic range of the 
							temperature bargraph is increased. In other words, 
							we can show temperatures all the way down to room 
							temperature on the bargraph yet still show small 
							changes in temperature at the airplane’s operating 
							temperature range. <br>As an example if we set our 
							Autorange Inflection to be 1200 deg then 
							temperatures below 1200 will be rendered with 
							relatively few pixels/degree whereas temperatures 
							above 1200 will be rendered with more pixels/degree 
							to make temperature changes more obvious.<br>
				The EGT Max 
							Temperature simply defines the temperature that is 
							represented by a bar that is full screen in height. 
							For example if EGT Max Temperature is set to 1600 
							deg than a temperature of 1600 deg will be rendered 
							as a bar that reaches the top of the screen.<br>The G3’s Autorange Inflection is always 400 deg 
							below the EGT Max Temperature. Adjusting one will 
							therefore always affect the other automatically.</p>
				<h4>EGT Smoothing</h4>
				<p>The lower the number the faster 
							the sampling but less smooth (jumpier)<br>The factory 
							preset is 32.</p>
				<h4>Adjusting the bar heights 
							from the main screen (Method 3):</h4>
							<p>An alternative way to setup the scale of the 
							temperature bargraphs can be performed from the main 
							screen. <br>Press the SEL button and a message 
							appears: “TURN-ADJUST BAR HEIGHT”. <br>By turning 
							the SEL button the heights of the bars may be moved 
							up and down. <br>Pressing the SEL button twice more 
							returns the G3-4 to its normal mode. <br>If we 
							return to the User Configuration screen, we will see 
							that EGT MAX TEMPERATURE and AUTORANGE <br>INFLECTION have been adjusted to reflect our changes 
							to the bar height. <br>If the adjustment is to 
							become permanent we must select Save Config and set 
							it to yes.			</p>	<hr style='color: rgb(85, 85, 85); font-family: junctionregularRegular, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant: normal; font-weight: normal; letter-spacing: normal; line-height: 23.1px; orphans: auto; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 1; word-spacing: 0px; -webkit-text-stroke-width: 0px;'>
				<div>
					<h2 style='color:red'>NEW Fuel Screens</h2>
					<h3><strong>Previously, there was no standard color scheme in 
					the configuration screens.</strong></h3>
					<p>Now, the selected line is yellow and the inactive lines are white. <br>YES/NO 
					in red has been removed by displaying only the word YES or 
					the word NO in green, when saving. <br>When there is a 
					choice of several items the selected item is displayed in 
					green. <br>Exactly one item is always selected. <br>The 
					choices of temperature units are Celsius or Fahrenheit then 
					either Fahrenheit or Celsius will be selected in green.</p>
					<h3>
					<strong>The FUEL TOTALIZATION screen has been improved and is 
					even easier to use.</strong></h3>
					<p>This change allows the pilot to see this screen before entering fuel on board. 
					<br>Also setting initial fuel can be checked and corrected in 
					flight. <br>Previously the pilot had to enter the amount of 
					fuel onboard before he could view the Fuel Totalization 
					page. <br>Now both the FUEL TOTALIZATION page and the 
							<strong>FUEL 
					SETUP</strong> page are accessible at any time. <br>On the 
							<strong>FUEL 
					TOTALIZATION</strong> screen simply press the PG (left) button to 
					enter fuel, press it again when done. As before you can 
					top up the tank(s) by turning the SEL (right) knob counter 
					clockwise on the very first click.</p>
					<h3><strong>Set total fuel onboard before take-off</strong></h3>
					<p>Your G2-3-4 was preset at factory with your usable 
					total fuel</p>
					<h4><em><strong>To reach the FUEL TOTALIZATION 
					screen from the main screen:</strong></em></h4>
					<ul><li>Turn the PG knob counterclockwise one click.</li>
						<li>Push PG knob to go back and forth between the 
						<strong>FUEL SETUP</strong> and <strong>FUEL TOTALIZATION</strong> screens</li> 
						<li>On FUEL SETUP screen setting fuel gallons the lines FUEL ADDED, SUBTOTAL and FUEL NOW color will be yellow. </li>
						<li>Turn SEL knob to set gallons (Clockwise or 
					Counterclockwise one click for total preset total fuel for 
					your aircraft) </li>
						<li>At any time, you can push PG knob to go back and forth 
					between the <strong>FUEL SETUP</strong> and <strong>FUEL TOTALIZATION</strong> screens to add 
					more fuel.</li></ul>
					<p class='style131' style='padding: 5px; margin: 0px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>&nbsp;<span class='Apple-converted-space'>&nbsp;<img alt='G4' height='243' src='Site/images/fuel1.png' width='251'><img alt='G4' height='245' src='Site/images/fuel2.png' width='258'></span></p>
					<p class='style131' style='padding: 5px; margin: 0px; text-align: center; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>G3-G4 have same screens</p>
					<p style='padding: 5px; margin: 0px; font-family: Arial, Helvetica, sans-serif; font-size: 12px; font-style: normal; line-height: 15px; font-weight: normal; color: rgb(51, 51, 51); background-image: url('Site/images/android_bg.png'); background-repeat: repeat;'>
					&nbsp;</p>
					<h4><strong style='font-weight: bold !important;'>FF Stability</strong></h4>
					<p>Displays, literally, the stability of your fuel flow over 
					the last few seconds. The smaller the number, the less the 
					fuel flow has varied in the past few seconds. A 
					well-regulated fuel system will have a small number, a 
					carbureted system can expect a larger number. The smaller 
					the number the more likely you are to get an accurate fuel 
					flow reading during the lean-find function. An larger number 
					will make things more difficult.</p>
					<h4><b>GEM FUEL TOTALIZER CAUTIONARY NOTICE<o:p></o:p></b></h4>
					<p>The Fuel Remaining display on the GEM is very useful but is 
					not without limitations. Understand first that the factory 
					fuel quantity gauges are the only instruments in the panel 
					that physically measure fuel level. They are still the 
					primary indication of fuel level in the airplane.</p>
					<p>The GEM doesn’t measure level, but instead measures only 
					fuel flow rate. The GEM totalizes the rate information to 
					account for fuel used. If you know how much fuel you started 
					with and how much you have used you can figure fuel 
					remaining by simple subtraction.</p>
					<p>The pilot must supply an accurate starting fuel level for 
					this subtraction to produce the correct fuel remaining 
					result. Should the pilot overstate the fuel quantity on 
					board, the GEM will dangerously overstate the fuel remaining 
					and the endurance time as well. The pilot must be careful 
					and diligent when setting the fuel on board.</p>
					<p>Getting the correct fuel total on board is in many cases 
					pretty easy. If you fill up prior to takeoff the number is 
					obviously the total available on board. If you partially 
					fill a known configuration (say tips empty) then the total 
					is easy to calculate. If you partially fill fuel tanks or 
					add an accurately know quantity to a poorly known original 
					value - errors will abound. Unaccounted fuel loss from 
					leakage, fuel vent overflow or theft will of course produce 
					erroneous results. So be careful and the GEM will deliver 
					safe, reliable, and convenient fuel information. But be sure 
					to cross reference the information on the primary fuel 
					quantity gauges. Never trust a single source of fuel 
					information when you have two on board. Fuel exhaustion 
					still ranks highly among accident causes. Don’t let your 
					engine stop until you’re parked.</p>
				</div>
				<div class='center'>
					<br><a href='#top'>
					<img alt='Top' height='40' src='Site/icons/back-top.png' width='100'></a></div>
				<p>&nbsp;</p>
				<!--/body content --></div>" }
            );

            context.SaveChanges();

            context.Updates.AddOrUpdate(x => x.UpdateID,
                new Update() { UpdateName = "Air Show Delayed",UpdateHeading ="No More Air!", posted = DateTime.Now, UpdateBody = " Pellentesque risus nibh, imperdiet efficitur lobortis vitae, lobortis sed enim. Quisque in fermentum magna. Cras faucibus eros eget quam pulvinar vestibulum. Nullam volutpat sodales nisl quis congue. Fusce tempus iaculis malesuada. Vestibulum ultricies augue dui, vitae fermentum lorem fringilla sit amet. Integer rutrum at dui et malesuada. Donec nulla ante, dictum in maximus vitae, rhoncus ac libero. Maecenas ex nunc, pellentesque sit amet condimentum vitae, egestas in purus. Sed placerat neque eget sapien ultricies, eget facilisis enim luctus. Ut ut sollicitudin risus, placerat accumsan enim. Pellentesque sit amet erat nec sapien congue consectetur sed ac arcu. Proin pulvinar accumsan nulla, ac posuere sapien ultricies et. Proin tincidunt hendrerit laoreet.Vivamus ornare molestie nibh ut ultrices.Integer scelerisque nulla lorem, in euismod sem efficitur at.Curabitur luctus arcu ligula, id tempus eros malesuada non.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Duis quam dolor, feugiat sit amet ornare ut,consectetur id ante.Morbi accumsan malesuada tempor.Aenean in metus ac magna imperdiet vestibulum.Cras orci odio, posuere id congue eget,imperdiet ac justo.Ut pharetra est metus,vitae pulvinar tellus pharetra vitae.Sed dignissim molestie libero et sollicitudin.Maecenas malesuada arcu eget sem tempor lobortis.In hac habitasse platea dictumst.Vestibulum nec luctus dui.Fusce laoreet mollis metus, eget egestas metus euismod at.Morbi commodo mauris nibh, tempor feugiat mi imperdiet a.Mauris sed viverra odio.Sed id vehicula enim.Vestibulum interdum sagittis scelerisque.Fusce lacinia dolor pulvinar diam consequat interdum vel in lorem. " },
                new Update() { UpdateName = "G2 Engine Monitor Released",UpdateHeading="After all these years!", posted = DateTime.Parse("2020-04-27"), UpdateBody = " Pellentesque risus nibh, imperdiet efficitur lobortis vitae, lobortis sed enim. Quisque in fermentum magna. Cras faucibus eros eget quam pulvinar vestibulum. Nullam volutpat sodales nisl quis congue. Fusce tempus iaculis malesuada. Vestibulum ultricies augue dui, vitae fermentum lorem fringilla sit amet. Integer rutrum at dui et malesuada. Donec nulla ante, dictum in maximus vitae, rhoncus ac libero. Maecenas ex nunc, pellentesque sit amet condimentum vitae, egestas in purus. Sed placerat neque eget sapien ultricies, eget facilisis enim luctus. Ut ut sollicitudin risus, placerat accumsan enim. Pellentesque sit amet erat nec sapien congue consectetur sed ac arcu. Proin pulvinar accumsan nulla, ac posuere sapien ultricies et. Proin tincidunt hendrerit laoreet.Vivamus ornare molestie nibh ut ultrices.Integer scelerisque nulla lorem, in euismod sem efficitur at.Curabitur luctus arcu ligula, id tempus eros malesuada non.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Duis quam dolor, feugiat sit amet ornare ut,consectetur id ante.Morbi accumsan malesuada tempor.Aenean in metus ac magna imperdiet vestibulum.Cras orci odio, posuere id congue eget,imperdiet ac justo.Ut pharetra est metus,vitae pulvinar tellus pharetra vitae.Sed dignissim molestie libero et sollicitudin.Maecenas malesuada arcu eget sem tempor lobortis.In hac habitasse platea dictumst.Vestibulum nec luctus dui.Fusce laoreet mollis metus, eget egestas metus euismod at.Morbi commodo mauris nibh, tempor feugiat mi imperdiet a.Mauris sed viverra odio.Sed id vehicula enim.Vestibulum interdum sagittis scelerisque.Fusce lacinia dolor pulvinar diam consequat interdum vel in lorem. " },
                new Update() { UpdateName = "Air Show August 3rd",UpdateHeading="The planes are coming to the skies!" ,posted = DateTime.Parse("2020-05-28"), UpdateBody = " Pellentesque risus nibh, imperdiet efficitur lobortis vitae, lobortis sed enim. Quisque in fermentum magna. Cras faucibus eros eget quam pulvinar vestibulum. Nullam volutpat sodales nisl quis congue. Fusce tempus iaculis malesuada. Vestibulum ultricies augue dui, vitae fermentum lorem fringilla sit amet. Integer rutrum at dui et malesuada. Donec nulla ante, dictum in maximus vitae, rhoncus ac libero. Maecenas ex nunc, pellentesque sit amet condimentum vitae, egestas in purus. Sed placerat neque eget sapien ultricies, eget facilisis enim luctus. Ut ut sollicitudin risus, placerat accumsan enim. Pellentesque sit amet erat nec sapien congue consectetur sed ac arcu. Proin pulvinar accumsan nulla, ac posuere sapien ultricies et. Proin tincidunt hendrerit laoreet.Vivamus ornare molestie nibh ut ultrices.Integer scelerisque nulla lorem, in euismod sem efficitur at.Curabitur luctus arcu ligula, id tempus eros malesuada non.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos.Duis quam dolor, feugiat sit amet ornare ut,consectetur id ante.Morbi accumsan malesuada tempor.Aenean in metus ac magna imperdiet vestibulum.Cras orci odio, posuere id congue eget,imperdiet ac justo.Ut pharetra est metus,vitae pulvinar tellus pharetra vitae.Sed dignissim molestie libero et sollicitudin.Maecenas malesuada arcu eget sem tempor lobortis.In hac habitasse platea dictumst.Vestibulum nec luctus dui.Fusce laoreet mollis metus, eget egestas metus euismod at.Morbi commodo mauris nibh, tempor feugiat mi imperdiet a.Mauris sed viverra odio.Sed id vehicula enim.Vestibulum interdum sagittis scelerisque.Fusce lacinia dolor pulvinar diam consequat interdum vel in lorem. " }
        );

            context.SaveChanges();

            context.ProductUpdateVMs.AddOrUpdate(x => x.ID,
                   new ProductUpdateVM() { Products = context.Products.ToList(), Updates = context.Updates.ToList() }
            );

            context.SaveChanges();

            context.SideProducts.AddOrUpdate(x => x.SideID, new SideProduct() { SideBody = "BODYTEXT", SideName = "MU-2 Torque Knee", SideShort = "MU-2" });

            //
        }
    }
}
