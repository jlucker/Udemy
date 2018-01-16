<template>
  <q-layout
    ref="layout"
    view="hHh Lpr fff"
    :left-class="{'bg-grey-2': true}"
  >
    <q-toolbar slot="header" class="" color="">
      <q-btn
        flat
        @click="$refs.layout.toggleLeft()"
      >
        <q-icon name="menu" />
      </q-btn>
      <q-toolbar-title>
        Performance Management
        <div slot="subtitle"><!--Running on Quasar v{{$q.version}}--></div>
      </q-toolbar-title>

      <q-btn flat>
        <q-icon name="account_box" />
      </q-btn>
    </q-toolbar>

    <div slot="left">
      <!--
        Use <q-side-link> component
        instead of <q-item> for
        internal vue-router navigation
      -->

      <q-list no-border link inset-delimiter>
        <q-list-header>Essential Links</q-list-header>
        <q-item @click="launch('')">
          <q-item-side icon="assessment" />
          <q-item-main label="Self-Evaluation" sublabel="My FY2018 Self-Evaluation Form" />
        </q-item>
        <q-item @click="launch('')">
          <q-item-side icon="account_circle" />
          <q-item-main label="Performance Management" sublabel="FY2018 Management Requests" />
        </q-item>
        <q-item @click="launch('')">
          <q-item-side icon="chat" />
          <q-item-main label="Performance Evaluation" sublabel="FY2018 Performance Evaluations" />
        </q-item>
        <q-item @click="launch('')">
          <q-item-side icon="help" />
          <q-item-main label="Help" sublabel="Ask some questions" />
        </q-item>
      </q-list>
    </div>

    <!--
      Replace following <div> with
      <router-view /> component
      if using subRoutes
    -->
    <!--<div class="layout-padding logo-container non-selectable no-pointer-events">
      <div class="logo" :style="position">
        <img src="~assets/quasar-logo-full.svg">
      </div>
    </div>-->
    <div class="layout-padding">
      <div class="row ">
        <div class="col-3 pm-fields">
          <q-input v-model="text" stack-label="Employee ID" placeholder="123456789"/>
        </div>
        <div class="col-3 pm-fields">
          <q-input v-model="text" stack-label="Employee Name" placeholder="Justin Lucker"/>
        </div>
        <div class="col-3 pm-fields">
          <q-input v-model="text" stack-label="Employee Job Title" placeholder="Systems Analyst Associate"/>
        </div>
      </div>
      <div class="row">
        <div class="col-3 pm-fields">
          <q-input v-model="text" stack-label="Department" placeholder="Research Technology Development"/>
        </div>
        <div class="col-3 pm-fields">
          <q-input v-model="text" stack-label="Supervisor Name" placeholder="Sean Dudley"/>
        </div>

      </div>
      <div class="row">
        <div class="col-3 pm-fields">

          <q-option-group
            color="primary"
            type="checkbox"
            v-model="group"
            :options="[
      { label: 'Manages Staff', value: 'op1' },
      { label: 'Research Faculty', value: 'op2' },
      { label: 'Postdoc', value: 'op3' }
    ]"
          />

        </div>
      </div>
    </div>
  </q-layout>
</template>

<script>
import {
  dom,
  event,
  openURL,
  QLayout,
  QToolbar,
  QToolbarTitle,
  QBtn,
  QIcon,
  QList,
  QListHeader,
  QItem,
  QItemSide,
  QItemMain,
  QInput,
  QOptionGroup
} from 'quasar'

const
  { viewport } = dom,
  { position } = event,
  moveForce = 30,
  rotateForce = 40,
  RAD_TO_DEG = 180 / Math.PI

function getRotationFromAccel (accelX, accelY, accelZ) {
  /* Reference: http://stackoverflow.com/questions/3755059/3d-accelerometer-calculate-the-orientation#answer-30195572 */
  const sign = accelZ > 0 ? 1 : -1
  const miu = 0.001

  return {
    roll: Math.atan2(accelY, sign * Math.sqrt(Math.pow(accelZ, 2) + miu * Math.pow(accelX, 2))) * RAD_TO_DEG,
    pitch: -Math.atan2(accelX, Math.sqrt(Math.pow(accelY, 2) + Math.pow(accelZ, 2))) * RAD_TO_DEG
  }
}

export default {
  name: 'index',
  components: {
    QLayout,
    QToolbar,
    QToolbarTitle,
    QBtn,
    QIcon,
    QList,
    QListHeader,
    QItem,
    QItemSide,
    QItemMain,
    QInput,
    QOptionGroup
  },
  data () {
    return {
      group: []
    }
  },
  computed: {
    position () {
      const transform = `rotateX(${this.rotateX}deg) rotateY(${this.rotateY}deg)`
      return {
        top: this.moveY + 'px',
        left: this.moveX + 'px',
        '-webkit-transform': transform,
        '-ms-transform': transform,
        transform
      }
    }
  },
  methods: {
    launch (url) {
      openURL(url)
    },
    move (evt) {
      const
        {width, height} = viewport(),
        {top, left} = position(evt),
        halfH = height / 2,
        halfW = width / 2

      this.moveX = (left - halfW) / halfW * -moveForce
      this.moveY = (top - halfH) / halfH * -moveForce
      this.rotateY = (left / width * rotateForce * 2) - rotateForce
      this.rotateX = -((top / height * rotateForce * 2) - rotateForce)
    },
    rotate (evt) {
      if (evt.rotationRate &&
          evt.rotationRate.beta !== null &&
          evt.rotationRate.gamma !== null) {
        this.rotateX = evt.rotationRate.beta * 0.7
        this.rotateY = evt.rotationRate.gamma * -0.7
      }
      else {
        /* evt.acceleration may be null in some cases, so we'll fall back
           to evt.accelerationIncludingGravity */
        const
          accelX = evt.acceleration.x || evt.accelerationIncludingGravity.x,
          accelY = evt.acceleration.y || evt.accelerationIncludingGravity.y,
          accelZ = evt.acceleration.z || evt.accelerationIncludingGravity.z - 9.81,
          rotation = getRotationFromAccel(accelX, accelY, accelZ)

        this.rotateX = rotation.roll * 0.7
        this.rotateY = rotation.pitch * -0.7
      }
    },
    orient (evt) {
      if (evt.beta === null || evt.gamma === null) {
        window.removeEventListener('deviceorientation', this.orient, false)
        this.orienting = false

        window.addEventListener('devicemotion', this.rotate, false)
      }
      else {
        this.rotateX = evt.beta * 0.7
        this.rotateY = evt.gamma * -0.7
      }
    }
  },
  mounted () {
    this.$nextTick(() => {
      if (this.orienting) {
        window.addEventListener('deviceorientation', this.orient, false)
      }
      else if (this.rotating) {
        window.addEventListener('devicemove', this.rotate, false)
      }
      else {
        document.addEventListener('mousemove', this.move)
      }
    })
  },
  beforeDestroy () {
    if (this.orienting) {
      window.removeEventListener('deviceorientation', this.orient, false)
    }
    else if (this.rotating) {
      window.removeEventListener('devicemove', this.rotate, false)
    }
    else {
      document.removeEventListener('mousemove', this.move)
    }
  }
}
</script>

<style>

  .pm-fields{
    padding-left: 30px;
    padding-top: 10px;
  }
</style>
