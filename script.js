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
// LAB'da verilen görevlerin hepsini yerine getirdim.

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
            clockElement.style.fontFamily = "'Iceberg', sans-serif";
            clockElement.style.color = "#000000";
            document.body.appendChild(clockElement);
        }

        updateClock(); // İlk başta, sayfa açılınca çalıştırması için
        setInterval(updateClock, 1000); // Her saniye güncellemesi için
    });

// Burada takıldığım kısımlarda W3Schools ve GPT'den yardım aldım.

    // Kullanıcı giriş bilgilerini saklamak için bir array oluşturdum
    const logData = [];

    // Login butonuna tıklanınca çalışacak fonksiyon
    function handleLogin(event) {
        event.preventDefault(); // Sayfanın yenilenmesini engellemek için

        // Kullanıcı adı ve şifreyi almak için
        const username = document.getElementById("username").value;
        const password = document.getElementById("password").value;

        // Eğer kullanıcı adı veya şifre boşsa, kaydetmemesi için
        if (username.trim() === "" || password.trim() === "") {
            console.log("Username or password can't be empty!");
            return;
        }

        // Kullanıcı bilgilerini objeye çevirip array'e eklemek için
        logData.push({ username, password });

        // Konsola tüm girişleri yazdırmak için
        console.log("All Login Attempts:", logData);
    }

    // Sayfa yüklendiğinde event listener eklemek için
    document.addEventListener("DOMContentLoaded", function () {
        const loginButton = document.getElementById("login-btn"); // Login butonunu seç
        if (loginButton) {
            loginButton.addEventListener("click", handleLogin);
        }
    });

    // H'ye basınca login ekranını gizleme ve göstermek için
    document.addEventListener("keydown", function (event) {
        if (event.key === "h" || event.key === "H") {
            const loginScreen = document.getElementById("login-screen");
            if (loginScreen) {
                if (loginScreen.style.display === "none" || loginScreen.style.opacity === "0") {
                    loginScreen.style.display = "flex"; // Tekrar açmak için
                    loginScreen.style.opacity = "1";
                    loginScreen.style.visibility = "visible";
                } else {
                    loginScreen.style.display = "none"; // Tamamen kapatmak için
                    loginScreen.style.opacity = "0";
                    loginScreen.style.visibility = "hidden";
                }
            }
        }
    });


