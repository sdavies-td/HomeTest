import firebase from "firebase/app";
import "firebase/firestore";
import "firebase/auth";

const fbConfig = {
  apiKey: "",
  authDomain: "pk-customer-orders.firebaseapp.com",
  projectId: "pk-customer-orders",
  storageBucket: "pk-customer-orders.appspot.com",
  messagingSenderId: "245193408999",
  appId: "",
};

firebase.initializeApp(fbConfig);
firebase.firestore();

export default firebase;
