<template>
  <table class="table table-striped">
    <thead class="table-dark">
      <tr>
        <td scope="col">#</td>
        <td scope="col">Date</td>
        <td scope="col">Mileage</td>
        <td scope="col">Description</td>
      </tr>
    </thead>
    <tbody>
      <tr v-for="record in records" :key="record.recordId">
        <th scope="col">{{record.recordId}}</th>
        <td>{{record.dateOfRecord}}</td>
        <td>{{record.mileage}}</td>
        <td>{{record.description}}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>
import api from "@/services/ApiService.js";

export default {
  data() {
    return {
      newRecord: {
        carId: this.carIdProp,
        dateOfRecord: Date,
        mileage: Number,
        description: String,
      },
      isShowForm: false,
    };
  },
  props: {
    records: Array,
  },
  computed: {
    showFormButton() {
      if (this.isShowForm) {
        return "Hide Form";
      } else {
        return "Add Record";
      }
    },
  },
  methdos: {
    addRecord() {
      api.postRecord(this.newRecord.carId, this.newRecord);
    },
  },
};
</script>

<style>
</style>