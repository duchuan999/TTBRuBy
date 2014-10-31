require 'test_helper'

class DmnhomsControllerTest < ActionController::TestCase
  setup do
    @dmnhom = dmnhoms(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:dmnhoms)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnhom" do
    assert_difference('Dmnhom.count') do
      post :create, dmnhom: { dmnhombc_id: @dmnhom.dmnhombc_id, dmnhomin: @dmnhom.dmnhomin, stt: @dmnhom.stt, ten: @dmnhom.ten }
    end

    assert_redirected_to dmnhom_path(assigns(:dmnhom))
  end

  test "should show dmnhom" do
    get :show, id: @dmnhom
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnhom
    assert_response :success
  end

  test "should update dmnhom" do
    patch :update, id: @dmnhom, dmnhom: { dmnhombc_id: @dmnhom.dmnhombc_id, dmnhomin: @dmnhom.dmnhomin, stt: @dmnhom.stt, ten: @dmnhom.ten }
    assert_redirected_to dmnhom_path(assigns(:dmnhom))
  end

  test "should destroy dmnhom" do
    assert_difference('Dmnhom.count', -1) do
      delete :destroy, id: @dmnhom
    end

    assert_redirected_to dmnhoms_path
  end
end
