require 'test_helper'

class DmnhominsControllerTest < ActionController::TestCase
  setup do
    @dmnhomin = dmnhomins(:one)
  end

  test "should get index" do
    get :index
    assert_response :success
    assert_not_nil assigns(:Dmnhomins)
  end

  test "should get new" do
    get :new
    assert_response :success
  end

  test "should create dmnhomin" do
    assert_difference('Dmnhomin.count') do
      post :create, dmnhomin: { stt: @dmnhomin.stt, ten: @dmnhomin.ten }
    end

    assert_redirected_to dmnhomin_path(assigns(:dmnhomin))
  end

  test "should show dmnhomin" do
    get :show, id: @dmnhomin
    assert_response :success
  end

  test "should get edit" do
    get :edit, id: @dmnhomin
    assert_response :success
  end

  test "should update dmnhomin" do
    patch :update, id: @dmnhomin, dmnhomin: { stt: @dmnhomin.stt, ten: @dmnhomin.ten }
    assert_redirected_to dmnhomin_path(assigns(:dmnhomin))
  end

  test "should destroy dmnhomin" do
    assert_difference('Dmnhomin.count', -1) do
      delete :destroy, id: @dmnhomin
    end

    assert_redirected_to dmnhomins_path
  end
end
