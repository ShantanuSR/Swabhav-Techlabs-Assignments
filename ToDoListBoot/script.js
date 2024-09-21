let data = document.querySelector("#inpid")

let btn = document.querySelector("#btn")
//let delbtn = document.querySelector(".btn btn-danger")
//let pElement = document.querySelector("#li1"); 
let ul = document.querySelector("ul"); 
// btn.addEventListener("click",()=>{
//     const res = document.createElement("li")
//     res.innerText = data.value
//     pElement.append(res)
//     data.value = ""
// })
let completedList = document.querySelector("#completed-list"); 
let array=[]
// btn.addEventListener("click",()=>{
//     const res = document.createElement("li")
//     res.innerText = data.value
//     if(!array.includes(data.value)){
//         array.push(data.value)
//         ul.appendChild(res)
//     }
//     else{
//         alert("Already exists")
//     }
    
//     console.log(array);
    
//     data.value = ""
// })

//let todoBtn = document.getElementById("todobtn")
 
//let todoInput = document.getElementById("todoinput");

 
btn.addEventListener('click', () => {
    const li = document.createElement("li");
    li.innerText = data.value;
    //ul.appendChild(li);

    if(!array.includes(data.value)){
        array.push(data.value)
        ul.appendChild(li)
    }
    else{
        alert("Already exists")
    }
    data.value = ""
    const trueBtn = document.createElement("button");

    trueBtn.innerText = "Done"; 
    trueBtn.classList.add("button","true-btn")

    const deleteBtn = document.createElement("button");
    deleteBtn.innerText = "Delete"; 
    deleteBtn.classList.add("button","delete-btn")

    li.appendChild(trueBtn);
    li.appendChild(deleteBtn);
    
    trueBtn.addEventListener('click', () => {
        li.style.textDecoration = "line-through"; 
        setTimeout(() => {
            li.removeChild(trueBtn);
            completedList.appendChild(li);
        }, 500); 

    });
 
    deleteBtn.addEventListener('click', () => {
        if (li.parentNode === ul) {
            ul.removeChild(li); 
        } else if (li.parentNode === completedList) {
            completedList.removeChild(li); 
        }
    });
})


// ul.addEventListener("click",(e)=>{
//     console.log(e.target);
//     if(e.target.nodeName === "LI")
//     {
//         const text = e.target.innerText
//         ul.removeChild(e.target)
//         const index = array.indexOf(text)
//         if(index !== -1)
//         {
//             array.splice(index,1)
//         }
//         //delete array[indexOf(e.target.innerText)]
//         //const a = indexOf(e.target)
        
//         console.log(array);
        
//     }

//})