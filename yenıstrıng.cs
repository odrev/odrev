<script>
    DateTime tarih;
    tarih= DateTime.Now.Date;
    console.Writeline(tarih.toString());

    console.Writeline(tarih.toString(TrimEnd)('0' , ':')); { 

int Gun = DateTime.Now.AddDays(5);
int Ay = DateTime.Now.Months(5);
int Yıl = DateTime.Now.Years(5);
int Saat = DateTime.Now.Hours(5);
int Dakika = DateTime.Now.Minutes(5);
int Saniye = DateTime.Now.AddSeconds(5);
int Salise = DateTime.Now.AddMilliseconds(5000);
}
console.Writeline(Gun.toString());
console.Writeline(Ay.toString());
console.Writeline(Yıl.toString());
console.Writeline(Saat.toString());
console.Writeline(Dakika.toString());
console.Writeline(Saniye.toString());
console.Writeline(Salise.toString());

</script>