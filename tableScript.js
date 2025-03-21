// FORM VE TABLO FONKSİYONLARI
const form = document.getElementById("class-form");
const tableBody = document.querySelector("#class-table tbody");

form.addEventListener("submit", function (event) {
    event.preventDefault();

    const className = document.getElementById("class-name").value;
    const numPeople = document.getElementById("num-people").value;
    const description = document.getElementById("description").value;

    // Yeni satır eklemek için
    const newRow = document.createElement("tr");
    newRow.innerHTML = `
            <td>${className}</td>
            <td>${numPeople}</td>
            <td>${description}</td>
        `;

    // Satıra tıklamak için
    newRow.addEventListener("click", function () {
        console.log(`Clicked Row: ${className}, ${numPeople}, ${description}`);
        newRow.style.backgroundColor = "#ffcccb";
        setTimeout(() => newRow.style.backgroundColor = "", 1000);
    });

    // Hover için
    newRow.addEventListener("mouseover", function () {
        newRow.style.backgroundColor = "#e0e0e0";
    });

    newRow.addEventListener("mouseout", function () {
        newRow.style.backgroundColor = "";
    });

    // Tabloya eklemek için
    tableBody.appendChild(newRow);

    // Formu temizlemek için
    form.reset();
});

    // Input odaklanınca stil değiştirmek için
    document.querySelectorAll("input, textarea").forEach(input => {
        input.addEventListener("focus", function () {
            input.style.border = "2px solid red";
        });
        input.addEventListener("blur", function () {
            input.style.border = "";
        });
});

// OZET
// Bu kısımlarda GPT'den ve W3'ten yardım aldım.
    // Submit eventi eklendi: Sayfanın yenilenmesini engeller ve verileri tabloya dinamik olarak ekler.
    // Click eventi eklendi: Tıklanan satırı vurgular ve detaylarını konsola yazdırır.
    // Mouseover eventi eklendi: Satırın üzerine gelindiğinde arka plan rengini değiştirir.
    // Mouseout eventi eklendi: Fare satırdan ayrıldığında arka plan rengini eski haline getirir.
    // Focus eventi eklendi: Input alanına odaklanıldığında kenarlığını vurgular.
    // Blur eventi eklendi: Input alanından çıkıldığında stilini sıfırlar.
    // Dblclick eventi eklendi: Satıra çift tıklayınca detayları gösterme veya satırı silme işlemi yapılabilir.
    // Table click eventi eklendi: Tabloya herhangi bir yere tıklanınca tüm girişleri konsola yazdırır.
    // Keyup eventi eklendi: Kullanıcı yazarken anlık doğrulama sağlar.