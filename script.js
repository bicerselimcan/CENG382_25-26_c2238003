// Canlı Saat Kısmı
function updateClock() {
    const clockElement = document.getElementById("live-clock");
    const now = new Date();
    const hours = now.getHours().toString().padStart(2, "0");
    const minutes = now.getMinutes().toString().padStart(2, "0");
    const seconds = now.getSeconds().toString().padStart(2, "0");
    clockElement.innerText = `${hours}:${minutes}:${seconds}`;
}

// Bu kısımlarda GPT'den yardım aldım ama bir ilk hafta oluştuduğum sayfa yapısından dolayı bazı şeyleri değiştirmek durumunda kaldım.
// LAB'da verilen görevleri (2-3) yerine getirdim fakat haftaya kadar sayfa yapısını değiştirip tekrar tüm görevleri yapacağım.

// Sayfa yüklendiğinde saati başlatmak için
document.addEventListener("DOMContentLoaded", function () {

    if (!document.getElementById("live-clock")) {
        const clockElement = document.createElement("div");
        clockElement.id = "live-clock";
        clockElement.style.position = "absolute";
        clockElement.style.top = "10px";
        clockElement.style.left = "50%";
        clockElement.style.transform = "translateX(-50%)";
        clockElement.style.fontSize = "36px";
        clockElement.style.fontFamily = "'Bebas Neue', sans-serif";
        clockElement.style.color = "#000000";
        document.body.appendChild(clockElement);
    }

    updateClock(); // İlk başta, sayfa açılınca çalıştırması için
    setInterval(updateClock, 1000); // Her saniye güncellemesi için
});

// H'ye basınca login ekranını gizleme ve gösterme
document.addEventListener("keydown", function (event) {
    if (event.key === "h" || event.key === "H") {
        const loginScreen = document.getElementById("login-screen"); // Login ekranı'nın div'i
        if (loginScreen) {
            if (loginScreen.style.display === "none" || loginScreen.style.opacity === "0") {
                loginScreen.style.display = "flex"; // Tekrar açmak için
                loginScreen.style.opacity = "1";
                loginScreen.style.visibility = "visible";
            } else {
                loginScreen.style.display = "none"; // Komple kapatmak için
                loginScreen.style.opacity = "0";
                loginScreen.style.visibility = "hidden";
            }
        }
    }
});