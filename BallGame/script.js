

let btnClick = document.querySelectorAll(".number-btn")

function RandomNumGeneration(){
    return (Math.floor(Math.random()*40)+1) // (max-min)+min
}

let RandomNum = RandomNumGeneration()

let count = 0
btnClick.forEach(button => {
    button.addEventListener("click",(e)=>{
        let value = e.target;
        if(RandomNum==value.textContent)
        {
            console.log("You clicked same number");
            value.classList.add("green-btn");
            setTimeout(()=> winnerDisplay(count),100)
        }
        else if(RandomNum <= value.textContent)
        {
            console.log("Generated number is smaller");
            value.classList.add("red-btn")
            
        }
        else if(RandomNum >= value.textContent)
        {
            console.log("Generated number is bigger");
            value.classList.add("yellow-btn")
        }
        count = count + 1;
        updateCountDisplay(count)
        if(count >= 6)
        {
            disableButtons();
            // afterLoosingBtn()
        }
    })

});

function unfreeze(){
    btnClick.forEach(btn=>{
        btn.classList.remove("disabled-btn")
        btn.classList.remove("green-btn")
        btn.classList.remove("red-btn")
        btn.classList.remove("yellow-btn")
        btn.disabled = false;
        
    })
    RandomNum = RandomNumGeneration()
}

function updateCountDisplay(count) {
    let p = document.querySelector(".attempts");
    if (p) {
        p.innerHTML = `Total Attempts: ${count}/6 `;
    }
    console.log(count);
}

function winnerDisplay(count) {
    alert(`You won in ${count} Attempts`)
}

function afterLoosingBtn() {
    const selectBtn = Array.from(btnClick).find(btn => btn.textContent == generatedNumber);
    if (selectBtn) {
        selectBtn.classList.add("green-btn");
    }
}

let freeze = document.querySelector("#resBtn")

freeze.addEventListener('click', () => {
    unfreeze()
    updateCountDisplay(count = 0)
    generatedNumber = randomNumberGen();
})

function disableButtons() {
    btnClick.forEach(btn => {
        btn.classList.add("disabled-btn");
        btn.disabled = true;
    });
    afterLoosingBtn()
    alert(`Your attempts are over`)
}