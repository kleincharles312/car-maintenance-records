import axios from 'axios'

axios.defaults.baseURL = process.env.VUE_APP_REMOTE_API;

export default {
    /**
     * Calls api for car specs for selected car
     * 
     * @param {Number} carId Id of selected car
     */
    getSpecs(carId){
        return axios.get(`${carId}`)
    },
    /**
     * Calls api for pic objects for selected car
     * 
     * @param {Number} carId Id of selected car
     * @return {Array} list of pic
     */
    getPics(carId){
        return axios.get(`${carId}/pics`)
    },
    /**
     * Calls api for records array for selected car
     * 
     * @param {Number} carId Id of selected car
     * @return {Array} list of records
     */
    getRecords(carId){
        return axios.get(`${carId}/records`)
    },
    /**
     * Posts new record for selected car
     * 
     * @param {Number} carId Id of selected car
     * @param {Object} newRecord New record to post
     * @return {Array} list of records
     */
    postRecord(carId, newRecord){
        return axios.post(`${carId}/records`, newRecord)
    }
}