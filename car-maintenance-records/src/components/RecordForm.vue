<template>
  <form @submit.prevent="addRecord" @reset.prevent="resetForm">
    <button
      class="btn btn-info btn-margin"
      @click.prevent="() => {isShowForm = !isShowForm}"
    >{{showFormButton}}</button>

    <div class="message" v-show="isMessage">{{message}}</div>

    <div class="form-box" v-show="isShowForm">
      <div class="input-spaced">
        <div>
          <label for="dateOfRecord">Date></label>
          <input type="date" name="dateOfRecord" required v-model="newRecord.dateOfRecord" />
        </div>

        <div>
          <label for="mileage">Mileage></label>
          <input type="number" name="mileage" min="0" max="1000000" required v-model="newRecord.mileage" />
        </div>
      </div>

      <label for="description">Description></label>
      <textarea name="description" cols="30" rows="10" required v-model="newRecord.description"></textarea>

      <div>
        <button type="submit" class="btn btn-success btn-margin">Submit</button>
        <button type="reset" class="btn btn-danger btn-margin">Clear</button>
      </div>
    </div>
  </form>
</template>

<script>
import api from "@/services/ApiService.js";

export default {
  data() {
    return {
      newRecord: {
        dateOfRecord: '',
        mileage: Number,
        description: "",
      },
      isShowForm: false,
      isMessage: false,
      message: "",
    };
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
  methods: {
    addRecord() {
        this.newRecord.carId = 1
        this.newRecord.recordId = 0   
        this.newRecord.mileage = parseInt(this.newRecord.mileage)             
        // TODO: get carId from url
      api.postRecord(this.newRecord.carId, this.newRecord).then( r => {
          if (r.status === 201){
              this.resetForm()
              this.message = 'Record Added'
              this.isMessage = true
              // TODO: emit event to reload records in home
          } else {
              // TODO: make error handling more robust
              this.message = 'Record not Added'
              this.isMessage = true
          }
      })
    },
    resetForm() {
      this.newRecord = {        
        dateOfRecord: Date,
        mileage: Number,
        description: "",
      };
      this.isShowForm = false;
    },
  },
  props: {
    carIdProp: Number,
  },
};
</script>

<style>
.btn-margin {
  margin: 1.5rem;
}
.input-spaced {
  display: flex;
  justify-content: space-evenly;
  flex-wrap: wrap;
}
.input-spaced input {
  margin-left: 0.5rem;
}
.form-box {
    display: flex;
    flex-direction: column;
}
</style>