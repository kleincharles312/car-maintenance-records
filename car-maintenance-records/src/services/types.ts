interface NameableVehicle {
    readonly year: string,
    readonly make: string,
    readonly model: string
}

let mini = {
    year: '2003',
    make: 'Mini',
    model: 'Cooper'
}

function getVehicleName(vehicle: NameableVehicle){
    return vehicle.year + ' ' + vehicle.make + ' ' + vehicle.model
}