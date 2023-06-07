using Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class StationConfigration : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasData(
                // For each new station Create new OBJ From Station

                // train number 164
                new Station
                {
                    Id = 11145600,
                    // Complete the data like following example
                    // Let Captial Letters as they are "Case Sensitive "
                    Name = "Alexandria",
                    //الإسْكَنْدَرِيَّة هي العاصمة الثانية لمصر وكانت عاصمتها قديمًا، وهي عاصمة محافظة الإسكندرية وأكبر مدنها، تقع على ساحل البحر الأبيض المتوسط.
                    Description = "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.",
                    Latitude = 31.193105781485116,
                    Longitude = 29.905233139369273,
                    NextStation = "Sidi Gaber",
                    TrainId = 164
                }
                // putting acomma ( , ) between each OBJ  
                ,
                new Station
                {
                    Id = 11225600,

                    Name = "Sidi Gaber",
                    //حي سيدي جابر؛ هو أحد الأحياء والمناطق الراقية بمدينة الإسكندرية في مصر.
                    Description = "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.",
                    Latitude = 31.21877615205961,
                    Longitude = 29.94230055156535,
                    NextStation = "Damanhour",
                    TrainId = 164
                }
                ,
                new Station
                {
                    Id = 10100120,

                    Name = "Damanhour",
                    //.يقع فيها مسجد التوبة وهو ثاني مسجد في أفريقيا أقامه عمرو بن العاص عام ٢١هـ
                    Description = "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.",
                    Latitude = 31.03453377085365,
                    Longitude = 30.468689104431753,
                    NextStation = "Tanta",
                    TrainId = 164
                }
                ,
                new Station
                {
                    Id = 1145100,

                    Name = "Tanta",
                    //.كلية القرآن الكريم (بطنطا) هي الأولى من نوعها بجامعة الأزهر، وليس لها نظير من حيث تخصّصها بالقرآن الكريم إلا كلية القرآن الكريم بالمدينة المنوّرة
                    //.منشأ المقرئ الشيخ محمود خليل الحصري
                    Description = "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.",
                    Latitude = 30.7819410292189,
                    Longitude = 30.99548398483424,
                    NextStation = "Birket el Sab",
                    TrainId = 164
                }
                ,
                new Station
                {
                    Id = 14514520,

                    Name = "Birket El Sab",
                    //واحدة من منشآت الهيئة العامة لقصور الثقافة بيت الثقافة ببركة السبع.
                    Description = "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.",
                    Latitude = 30.637454507182532,
                    Longitude = 31.079936683751335,
                    NextStation = "Qewaisna",
                    TrainId = 164
                }
                ,
                new Station
                {
                    Id = 14512002,

                    Name = "Qewaisna",
                    //يوجد بقويسنا طريق الحرب وقد استخدم هذا الطريق وقت الحرب لنقل المعدات والذخائر.
                    //.تم إنشاء عام ٢٠١٩ جامعة الدلتا التكنولوجية بقويسنا وتضم أربع تخصصات في مجال التقنية
                    Description = "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.",
                    Latitude = 30.547991778887262,
                    Longitude = 31.13991990441926,
                    NextStation = "Banha",
                    TrainId = 164
                }
                ,
                new Station
                {
                    Id = 14512345,

                    Name = "Banha",
                    //.تلقب "بنها العسل" حيث تنتج أجود أنواع عسل النحل
                    Description = "It is called Banha Al - Assal as it produces the finest types of bee honey.",
                    Latitude = 30.45595348899839,
                    Longitude = 31.181093848594685,
                    NextStation = "Ramsis(Cairo)",
                    TrainId = 164
                }
                ,
                new Station
                {
                    Id = 14512400,

                    Name = "Ramsis(Cairo)",
                    //القاهرة فى المرتبة 35 كأطول خط مترو بين 114 مدينة على مستوى العالم.
                    Description = "Cairo is ranked 35th as the longest metro line among 114 cities in the world.",
                    Latitude = 30.06323162819165,
                    Longitude = 31.246724130095895,
                    NextStation = "nextStation",
                    TrainId = 164
                }
                ,

                // train number 914
                new Station
                {
                    Id = 145124505,

                    Name = "Alexandria",
                    //الإسْكَنْدَرِيَّة هي العاصمة الثانية لمصر وكانت عاصمتها قديمًا، وهي عاصمة محافظة الإسكندرية وأكبر مدنها، تقع على ساحل البحر الأبيض المتوسط.
                    Description = "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.",
                    Latitude = 31.193105781485116,
                    Longitude = 29.905233139369273,
                    NextStation = "Sidi Gaber",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 14510534,

                    Name = "Sidi Gaber",
                    //حي سيدي جابر؛ هو أحد الأحياء والمناطق الراقية بمدينة الإسكندرية في مصر.
                    Description = "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.",
                    Latitude = 31.21877615205961,
                    Longitude = 29.94230055156535,
                    NextStation = "Damanhour",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 145123487,

                    Name = "Damanhour",
                    //.يقع فيها مسجد التوبة وهو ثاني مسجد في أفريقيا أقامه عمرو بن العاص عام ٢١هـ
                    Description = "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.",
                    Latitude = 31.03453377085365,
                    Longitude = 30.468689104431753,
                    NextStation = "Itay El Barud",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 1045452120,

                    Name = "Itay El Barud",
                    //منشأ الشيخ محمد الغزالي.
                    Description = "The origin of Sheikh Muhammad Al-Ghazali.",
                    Latitude = 30.887954013325928,
                    Longitude = 30.67008637907707,
                    NextStation = "Kafr El-Zayat",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 10405120,

                    Name = "Kafr El-Zayat",
                    //افتتاح معرض أهلًا رمضان بكفر الزيات لتوفير السلع الغذائية للمواطنين ٢٠٢٣.
                    Description = "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.",
                    Latitude = 30.81945162969096,
                    Longitude = 30.81453886579513,
                    NextStation = "Tanta",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 145114580,

                    Name = "Tanta",
                    //.كلية القرآن الكريم (بطنطا) هي الأولى من نوعها بجامعة الأزهر، وليس لها نظير من حيث تخصّصها بالقرآن الكريم إلا كلية القرآن الكريم بالمدينة المنوّرة
                    //.منشأ المقرئ الشيخ محمود خليل الحصري
                    Description = "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.",
                    Latitude = 30.7819410292189,
                    Longitude = 30.99548398483424,
                    NextStation = "Birket el Sab",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 145127400,

                    Name = "Birket El Sab",
                    //واحدة من منشآت الهيئة العامة لقصور الثقافة بيت الثقافة ببركة السبع.
                    Description = "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.",
                    Latitude = 30.637454507182532,
                    Longitude = 31.079936683751335,
                    NextStation = "Qewaisna",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 145127445,

                    Name = "Qewaisna",
                    //يوجد بقويسنا طريق الحرب وقد استخدم هذا الطريق وقت الحرب لنقل المعدات والذخائر.
                    //.تم إنشاء عام ٢٠١٩ جامعة الدلتا التكنولوجية بقويسنا وتضم أربع تخصصات في مجال التقنية
                    Description = "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.",
                    Latitude = 30.547991778887262,
                    Longitude = 31.13991990441926,
                    NextStation = "Banha",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 1478913620,

                    Name = "Banha",
                    //.تلقب "بنها العسل" حيث تنتج أجود أنواع عسل النحل
                    Description = "It is called Banha Al - Assal as it produces the finest types of bee honey.",
                    Latitude = 30.45595348899839,
                    Longitude = 31.181093848594685,
                    NextStation = "Ramsis(Cairo)",
                    TrainId = 914
                }
                ,
                new Station
                {
                    Id = 1004875120,

                    Name = "Ramsis(Cairo)",
                    //القاهرة فى المرتبة 35 كأطول خط مترو بين 114 مدينة على مستوى العالم.
                    Description = "Cairo is ranked 35th as the longest metro line among 114 cities in the world.",
                    Latitude = 30.06323162819165,
                    Longitude = 31.246724130095895,
                    NextStation = "nextStation",
                    TrainId = 914
                }
                ,

                // train number 18
                new Station
                {
                    Id = 1331520,

                    Name = "Alexandria",
                    //الإسْكَنْدَرِيَّة هي العاصمة الثانية لمصر وكانت عاصمتها قديمًا، وهي عاصمة محافظة الإسكندرية وأكبر مدنها، تقع على ساحل البحر الأبيض المتوسط.
                    Description = "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.",
                    Latitude = 31.193105781485116,
                    Longitude = 29.905233139369273,
                    NextStation = "Sidi Gaber",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 130313120,

                    Name = "Sidi Gaber",
                    //حي سيدي جابر؛ هو أحد الأحياء والمناطق الراقية بمدينة الإسكندرية في مصر.
                    Description = "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.",
                    Latitude = 31.21877615205961,
                    Longitude = 29.94230055156535,
                    NextStation = "Kafr El Dawwar",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 105433120,

                    Name = " Kafr El Dawwar",
                    //شركة مصر للغزل والنسيج بكفر الدوار هي أكبر الشركات في المدينة، وتأتي في المرتبة الثانية على مستوى مصر بعد شركة مصر للغزل والنسيج بمدينة المحلة الكبرى.
                    Description = "Misr Spinning and Weaving Company in Kafr El-Dawar is the largest company in the city, and it comes in second place in Egypt after Misr Spinning and Weaving Company in El-Mahalla El-Kubra.",
                    Latitude = 31.132741286101705,
                    Longitude = 30.130901427172223,
                    NextStation = "Abu Humus",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 1331201210,
                    Name = "Abu Humus",
                    //من المعالم الأثرية بمركز أبو حمص تل كوم تقالة الأثري وهو عبارة عن منطقة يحتمل وجود آثار بها وهو يقع جنوب عزبة الصاوي.
                    Description = "Among the archaeological monuments in the Abu Hummus center is Tel Koum Archaeological Center, which is an area where there are likely to be antiquities, and it is located south of Ezbet El Sawy.",
                    Latitude = 31.085098233708155,
                    Longitude = 30.31039202532206,
                    NextStation = "Damanhour",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 1303202120,

                    Name = "Damanhour",
                    //.يقع فيها مسجد التوبة وهو ثاني مسجد في أفريقيا أقامه عمرو بن العاص عام ٢١هـ
                    Description = "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.",
                    Latitude = 31.03453377085365,
                    Longitude = 30.468689104431753,
                    NextStation = "Itay El Barud",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 15132120,

                    Name = "Itay El Barud",
                    //منشأ الشيخ محمد الغزالي.
                    Description = "The origin of Sheikh Muhammad Al-Ghazali.",
                    Latitude = 30.887954013325928,
                    Longitude = 30.67008637907707,
                    NextStation = "Tawfiqia",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 18821230,

                    Name = "Tawfiqia",
                    //مستشفى التوفيقية تقع على الطريق الزراعي وتخدم جميع حوادث الطريق من طنطا لكفر الدوار.
                    Description = "Al Tawfiqia Hospital is located on the agricultural road and serves all road accidents from Tanta to Kafr El Dawwar.",
                    Latitude = 30.816339320978063,
                    Longitude = 30.748217873741716,
                    NextStation = "Kafr El-Zayat",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 18872121,

                    Name = "Kafr El-Zayat",
                    //افتتاح معرض أهلًا رمضان بكفر الزيات لتوفير السلع الغذائية للمواطنين ٢٠٢٣.
                    Description = "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.",
                    Latitude = 30.81945162969096,
                    Longitude = 30.81453886579513,
                    NextStation = "Tanta",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 1821021,

                    Name = "Tanta",
                    //.كلية القرآن الكريم (بطنطا) هي الأولى من نوعها بجامعة الأزهر، وليس لها نظير من حيث تخصّصها بالقرآن الكريم إلا كلية القرآن الكريم بالمدينة المنوّرة
                    //.منشأ المقرئ الشيخ محمود خليل الحصري
                    Description = "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.",
                    Latitude = 30.7819410292189,
                    Longitude = 30.99548398483424,
                    NextStation = "Birket el Sab",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 11723120,

                    Name = "Birket El Sab",
                    //واحدة من منشآت الهيئة العامة لقصور الثقافة بيت الثقافة ببركة السبع.
                    Description = "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.",
                    Latitude = 30.637454507182532,
                    Longitude = 31.079936683751335,
                    NextStation = "Qewaisna",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 182154220,

                    Name = "Qewaisna",
                    //يوجد بقويسنا طريق الحرب وقد استخدم هذا الطريق وقت الحرب لنقل المعدات والذخائر.
                    //.تم إنشاء عام ٢٠١٩ جامعة الدلتا التكنولوجية بقويسنا وتضم أربع تخصصات في مجال التقنية
                    Description = "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.",
                    Latitude = 30.547991778887262,
                    Longitude = 31.13991990441926,
                    NextStation = "Banha",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 210212210,

                    Name = "Banha",
                    //.تلقب "بنها العسل" حيث تنتج أجود أنواع عسل النحل
                    Description = "It is called Banha Al - Assal as it produces the finest types of bee honey.",
                    Latitude = 30.45595348899839,
                    Longitude = 31.181093848594685,
                    NextStation = "Toukh",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 2102120,

                    Name = "Toukh",
                    //مركز ومدينة طوخ، بوسط محافظة القليوبية. وهي من القرى القديمة.
                    Description = "The center and city of Toukh, in the center of Qalyubia Governorate. It is one of the ancient villages.",
                    Latitude = 30.35161544038919,
                    Longitude = 31.198362936947632,
                    NextStation = "Qaha",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 201021020,

                    Name = "Qaha",
                    //شركة قها للأغذية المحفوظة هي شركة مساهمة حكومية مصرية، تمتلكها الشركة القابضة للصناعات الغذائية إحدى شركات وزارة التموين والتجارة الداخلية، تعمل في مجال الصناعات الغذائية.
                    Description = "Qaha Preserved Food Company is an Egyptian government joint stock company, owned by the Holding Company for Food Industries, one of the companies of the Ministry of Supply and Internal Trade, working in the field of food industries.",
                    Latitude = 30.285198657390623,
                    Longitude = 31.208928538794947,
                    NextStation = "Shubra El Kheima",
                    TrainId = 18
                }
                ,
                new Station
                {
                    Id = 24052120,

                    Name = "Shubra El Kheima",
                    //شبرا الخيمه من ضواحى القاهره. فى الاصل اتعرفت بأسامى شبرا الشهيد و شبرا البلد و كمان اتعرفت بإسم شبرا دمنهورنسبه لمدينه جنبها كان اسمها دمنهور.
                    Description = "Shubra El Kheima, a suburb of Cairo. Originally, I was known by the names of Shubra al-Shaheed and Shubra al-Balad, and I was also known as Shubra Damanhour, after the city next to it called Damanhour.",
                    Latitude = 30.1222419599518,
                    Longitude = 31.244513237455582,
                    NextStation = "nextStation",
                    TrainId = 18
                }
                ,

                // train number 916
                new Station
                {
                    Id = 33021020,

                    Name = "Alexandria",
                    //الإسْكَنْدَرِيَّة هي العاصمة الثانية لمصر وكانت عاصمتها قديمًا، وهي عاصمة محافظة الإسكندرية وأكبر مدنها، تقع على ساحل البحر الأبيض المتوسط.
                    Description = "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.",
                    Latitude = 31.193105781485116,
                    Longitude = 29.905233139369273,
                    NextStation = "Sidi Gaber",
                    TrainId = 916
                }
                ,
                new Station
                {
                    Id = 3302120,

                    Name = "Sidi Gaber",
                    //حي سيدي جابر؛ هو أحد الأحياء والمناطق الراقية بمدينة الإسكندرية في مصر.
                    Description = "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.",
                    Latitude = 31.21877615205961,
                    Longitude = 29.94230055156535,
                    NextStation = "Ramsis(Cairo)",
                    TrainId = 916
                }
                ,
                new Station
                {
                    Id = 33021101,

                    Name = "Ramsis(Cairo)",
                    //القاهرة فى المرتبة 35 كأطول خط مترو بين 114 مدينة على مستوى العالم.
                    Description = "Cairo is ranked 35th as the longest metro line among 114 cities in the world.",
                    Latitude = 30.06323162819165,
                    Longitude = 31.246724130095895,
                    NextStation = "nextStation",
                    TrainId = 916
                }
                ,

                // train number 24
                new Station
                {
                    Id = 330211203,

                    Name = "Alexandria",
                    //الإسْكَنْدَرِيَّة هي العاصمة الثانية لمصر وكانت عاصمتها قديمًا، وهي عاصمة محافظة الإسكندرية وأكبر مدنها، تقع على ساحل البحر الأبيض المتوسط.
                    Description = "Alexandria is the second capital of Egypt and was its capital in the past. It is the capital of Alexandria Governorate and its largest city, located on the Mediterranean coast.",
                    Latitude = 31.193105781485116,
                    Longitude = 29.905233139369273,
                    NextStation = "Sidi Gaber",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 303021200,

                    Name = "Sidi Gaber",
                    //حي سيدي جابر؛ هو أحد الأحياء والمناطق الراقية بمدينة الإسكندرية في مصر.
                    Description = "Sidi Gaber district; It is one of the high-end neighborhoods and areas in Alexandria, Egypt.",
                    Latitude = 31.21877615205961,
                    Longitude = 29.94230055156535,
                    NextStation = "Kafr El Dawwar",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 302002120,

                    Name = " Kafr El Dawwar",
                    //شركة مصر للغزل والنسيج بكفر الدوار هي أكبر الشركات في المدينة، وتأتي في المرتبة الثانية على مستوى مصر بعد شركة مصر للغزل والنسيج بمدينة المحلة الكبرى.
                    Description = "Misr Spinning and Weaving Company in Kafr El-Dawar is the largest company in the city, and it comes in second place in Egypt after Misr Spinning and Weaving Company in El-Mahalla El-Kubra.",
                    Latitude = 31.132741286101705,
                    Longitude = 30.130901427172223,
                    NextStation = "Abu Humus",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 330302120,

                    Name = "Abu Humus",
                    //من المعالم الأثرية بمركز أبو حمص تل كوم تقالة الأثري وهو عبارة عن منطقة يحتمل وجود آثار بها وهو يقع جنوب عزبة الصاوي.
                    Description = "Among the archaeological monuments in the Abu Hummus center is Tel Koum Archaeological Center, which is an area where there are likely to be antiquities, and it is located south of Ezbet El Sawy.",
                    Latitude = 31.085098233708155,
                    Longitude = 30.31039202532206,
                    NextStation = "Damanhour",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 404002120,

                    Name = "Damanhour",
                    //.يقع فيها مسجد التوبة وهو ثاني مسجد في أفريقيا أقامه عمرو بن العاص عام ٢١هـ
                    Description = "The Al-Tawbah Mosque is located in it, and it is the second mosque in Africa that was built by Amr bin Al-Aas in the year 21 AH.",
                    Latitude = 31.03453377085365,
                    Longitude = 30.468689104431753,
                    NextStation = "Itay El Barud",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 45021020,

                    Name = "Itay El Barud",
                    //منشأ الشيخ محمد الغزالي.
                    Description = "The origin of Sheikh Muhammad Al-Ghazali.",
                    Latitude = 30.887954013325928,
                    Longitude = 30.67008637907707,
                    NextStation = "Tawfiqia",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 125021020,

                    Name = "Tawfiqia",
                    //مستشفى التوفيقية تقع على الطريق الزراعي وتخدم جميع حوادث الطريق من طنطا لكفر الدوار.
                    Description = "Al Tawfiqia Hospital is located on the agricultural road and serves all road accidents from Tanta to Kafr El Dawwar.",
                    Latitude = 30.816339320978063,
                    Longitude = 30.748217873741716,
                    NextStation = "Kafr El-Zayat",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 451021020,

                    Name = "Kafr El-Zayat",
                    //افتتاح معرض أهلًا رمضان بكفر الزيات لتوفير السلع الغذائية للمواطنين ٢٠٢٣.
                    Description = "The opening of the Welcome Ramadan exhibition in Kafr El-Zayyat to provide food commodities to citizens 2023.",
                    Latitude = 30.81945162969096,
                    Longitude = 30.81453886579513,
                    NextStation = "Tanta",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 45002129,

                    Name = "Tanta",
                    //.كلية القرآن الكريم (بطنطا) هي الأولى من نوعها بجامعة الأزهر، وليس لها نظير من حيث تخصّصها بالقرآن الكريم إلا كلية القرآن الكريم بالمدينة المنوّرة
                    //.منشأ المقرئ الشيخ محمود خليل الحصري
                    Description = "The College of the Holy Qur’an (Tanta) is the first of its kind at Al-Azhar University, and it has no equal in terms of its specialization in the Holy Qur’an except for the College of the Holy Qur’an in Medina. The origin of the reciter, Sheikh Mahmoud Khalil Al-Husri.",
                    Latitude = 30.7819410292189,
                    Longitude = 30.99548398483424,
                    NextStation = "Birket el Sab",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 99021020,

                    Name = "Birket El Sab",
                    //واحدة من منشآت الهيئة العامة لقصور الثقافة بيت الثقافة ببركة السبع.
                    Description = "One of the facilities of the General Authority for Culture Palaces is the House of Culture in Birket El Sab.",
                    Latitude = 30.637454507182532,
                    Longitude = 31.079936683751335,
                    NextStation = "Qewaisna",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 90902120,

                    Name = "Qewaisna",
                    //يوجد بقويسنا طريق الحرب وقد استخدم هذا الطريق وقت الحرب لنقل المعدات والذخائر.
                    //.تم إنشاء عام ٢٠١٩ جامعة الدلتا التكنولوجية بقويسنا وتضم أربع تخصصات في مجال التقنية
                    Description = "There is a war road in Quesna, and this road was used during the war to transport equipment and ammunition. The Delta University of Technology was established in 2019 in Quesna and includes four majors in the field of technology.",
                    Latitude = 30.547991778887262,
                    Longitude = 31.13991990441926,
                    NextStation = "Banha",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 45002450,

                    Name = "Banha",
                    //.تلقب "بنها العسل" حيث تنتج أجود أنواع عسل النحل
                    Description = "It is called Banha Al - Assal as it produces the finest types of bee honey.",
                    Latitude = 30.45595348899839,
                    Longitude = 31.181093848594685,
                    NextStation = "Toukh",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 413020120,

                    Name = "Toukh",
                    //مركز ومدينة طوخ، بوسط محافظة القليوبية. وهي من القرى القديمة.
                    Description = "The center and city of Toukh, in the center of Qalyubia Governorate. It is one of the ancient villages.",
                    Latitude = 30.35161544038919,
                    Longitude = 31.198362936947632,
                    NextStation = "Qaha",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 21200,

                    Name = "Qaha",
                    //شركة قها للأغذية المحفوظة هي شركة مساهمة حكومية مصرية، تمتلكها الشركة القابضة للصناعات الغذائية إحدى شركات وزارة التموين والتجارة الداخلية، تعمل في مجال الصناعات الغذائية.
                    Description = "Qaha Preserved Food Company is an Egyptian government joint stock company, owned by the Holding Company for Food Industries, one of the companies of the Ministry of Supply and Internal Trade, working in the field of food industries.",
                    Latitude = 30.285198657390623,
                    Longitude = 31.208928538794947,
                    NextStation = "Qelyoub",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 212022,

                    Name = "Qelyoub",
                    //من الآثار الإسلامية جامع الظاهر بيبرس وقد بنى عام 670-672 هـ بقرية قليوب.
                    Description = "Among the Islamic monuments is Al-Zahir Baybars Mosque, which was built in the year 670-672 AH in the village of Qalyub.",
                    Latitude = 30.187796088125985,
                    Longitude = 31.22807432746081,
                    NextStation = "Shubra El Kheima",
                    TrainId = 24
                }
                ,
                new Station
                {
                    Id = 2018020,

                    Name = "Shubra El Kheima",
                    //شبرا الخيمه من ضواحى القاهره. فى الاصل اتعرفت بأسامى شبرا الشهيد و شبرا البلد و كمان اتعرفت بإسم شبرا دمنهورنسبه لمدينه جنبها كان اسمها دمنهور.
                    Description = "Shubra El Kheima, a suburb of Cairo. Originally, I was known by the names of Shubra al-Shaheed and Shubra al-Balad, and I was also known as Shubra Damanhour, after the city next to it called Damanhour.",
                    Latitude = 30.1222419599518,
                    Longitude = 31.244513237455582,
                    NextStation = "nextStation",
                    TrainId = 24
                }
                ,

                new Station
                {
                    Id = 188120,

                    Name = "name",
                    Description = "description",
                    Latitude = 0,
                    Longitude = 0,
                    NextStation = "nextStation",
                    TrainId = 0
                }
                );
        }
    }
}
