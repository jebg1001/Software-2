

$("#asignarCaracteristica").click(function(){

const { value: text } =  Swal.fire({
  input: 'textarea',
  inputLabel: 'Message',
  inputPlaceholder: 'Type your message here...',
  inputAttributes: {
    'aria-label': 'Type your message here'
  },
  showCancelButton: true
})

if (text) {
  Swal.fire(text)
}

})


$("#registrar").click(function(){
  Swal.fire({
    position: 'center',
    icon: 'success',
    title: 'Registro exitoso',
    showConfirmButton: false,
    timer: 1500
  })
  })
  


  $("#registrar1").click(function(){
    Swal.fire({
      position: 'center',
      icon: 'success',
      title: 'El cliente se registró exitosamente',
      showConfirmButton: false,
      timer: 1500
    })
    })


    $("#agregarEntrada").click(function(){
      Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'Se agrego correctamente',
        showConfirmButton: false,
        timer: 1500
      })
      })


      $("#retirarSalida").click(function(){
        Swal.fire({
          position: 'center',
          icon: 'success',
          title: 'Se retiro correctamente',
          showConfirmButton: false,
          timer: 1500
        })
        })


      $("#cancelar").click(function(){
        Swal.fire({
          position: 'center',
          icon: 'error',
          title: 'Se cancelo la operación',
          showConfirmButton: false,
          timer: 1500
        })
        })
    


    $("#eliminar1").click(function(){
      Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'El calzado a sido eliminado',
        showConfirmButton: false,
        timer: 1500
      })
      })
      

      $("#eliminar2").click(function(){
        Swal.fire({
          position: 'center',
          icon: 'success',
          title: 'El calzado a sido eliminado',
          showConfirmButton: false,
          timer: 1500
        })
        })
        
  


        $("#eliminar3").click(function(){
          Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'El calzado a sido eliminado',
            showConfirmButton: false,
            timer: 1500
          })
          })
          
    
          $("#eliminar4").click(function(){
            Swal.fire({
              position: 'center',
              icon: 'success',
              title: 'El calzado a sido eliminado',
              showConfirmButton: false,
              timer: 1500
            })
            })
            
            $("#eliminar5").click(function(){
              Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'El calzado a sido eliminado',
                showConfirmButton: false,
                timer: 1500
              })
              })
              
        
              $("#eliminar6").click(function(){
                Swal.fire({
                  position: 'center',
                  icon: 'success',
                  title: 'El calzado a sido eliminado',
                  showConfirmButton: false,
                  timer: 1500
                })
                })

                